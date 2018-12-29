import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { JwtHelperService } from "@auth0/angular-jwt";
import { BehaviorSubject, Observable } from "rxjs";
import { distinctUntilChanged, map } from "rxjs/operators";
import { AppConfig } from "../../../app-config";
import { User } from "../../shared/models/user.model";
import { UserRegistrationModel } from "src/app/shared/models/user-registration.model";

@Injectable()
export class AuthService {
  public currentUser: Observable<User>;
  private baseUrl = AppConfig.identityURI;
  private jwtHelper: JwtHelperService;
  private currentUserSubject = new BehaviorSubject<User>(null);

  constructor(private http: HttpClient) {
    this.currentUser = this.currentUserSubject
      .asObservable()
      .pipe(distinctUntilChanged());
    this.jwtHelper = new JwtHelperService();
  }

  public signIn(userName: string, password: string): Observable<User> {
    return this.http
      .post(
        this.baseUrl + "/account/sign-in",
        JSON.stringify({ userName, password })
      )
      .pipe(
        map((res: any) => {
          const response = JSON.parse(res);
          this.setToken(response.auth_token);
          const payload = this.jwtHelper.decodeToken(response.auth_token);
          const user = { email: payload.sub } as User;
          this.currentUserSubject.next(user);
          return user;
        })
      );
  }

  public register(user: UserRegistrationModel): Observable<any> {
    return this.http.post(
      this.baseUrl + "/account/register",
      JSON.stringify(user)
    );
  }

  public signOut() {
    this.removeToken();
    this.currentUserSubject.next(null);
  }

  public isAuthenticated(): boolean {
    const token = this.getToken();

    if (token) {
      if (this.isTokenExpired(token)) {
        return false;
      }

      if (!this.getCurrentUser()) {
        this.storeCurrentUserData(token);
      }

      return true;
    }
    return false;
  }

  public getCurrentUser(): User {
    return this.currentUserSubject.value;
  }

  private isTokenExpired(token) {
    const payload = this.jwtHelper.decodeToken(token);
    return Date.now() / 1000 > payload.exp;
  }

  private storeCurrentUserData(token) {
    const payload = this.jwtHelper.decodeToken(token);
    const user = { email: payload.sub } as User;
    this.currentUserSubject.next(user);
  }

  private getToken(): string {
    return localStorage.getItem("auth_token");
  }

  private setToken(token: string): void {
    localStorage.setItem("auth_token", token);
  }

  private removeToken(): void {
    localStorage.removeItem("auth_token");
  }
}

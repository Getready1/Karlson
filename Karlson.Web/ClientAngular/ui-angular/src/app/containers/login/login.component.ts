import { Component, OnInit } from "@angular/core";
import { FormGroup, FormControl, Validators } from "@angular/forms";
import { AuthService } from "src/app/core/services/auth.service";
import { Router } from "@angular/router";
import { UserRegistrationModel } from "src/app/shared/models/user-registration.model";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.scss"]
})
export class LoginComponent implements OnInit {
  public form = new FormGroup({
    email: new FormControl("", [Validators.required, Validators.email]),
    password: new FormControl("", [Validators.required])
  });

  public errorMessages: string[] = [];

  constructor(public authService: AuthService, private router: Router) {}

  ngOnInit() {}

  public onSubmit() {
    const model = this.form.value as { email: string; password: string };

    this.authService.signIn(model.email, model.password).subscribe(
      () => {
        this.router.navigate(["/home"]);
      },
      (error: any) => {
        this.errorMessages = Object.keys(error.error).map(
          message => error.error[message]
        );
      }
    );
  }
}

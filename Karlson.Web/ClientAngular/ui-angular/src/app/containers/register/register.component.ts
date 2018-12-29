import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Validators } from '@angular/forms';
import { FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/core/services/auth.service';
import { UserRegistrationModel } from 'src/app/shared/models/user-registration.model';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  public form = new FormGroup({
    passwordConfirmation: new FormControl('', [Validators.required]),
    password: new FormControl('', [Validators.required]),
    email: new FormControl('', [Validators.required, Validators.email]),
    firstName: new FormControl('', []),
    lastName: new FormControl('', [])
  });
  public errorMessages: string[] = [];

  constructor(public authService: AuthService, private router: Router) {}

  ngOnInit() {}

  public onSubmit() {
    const model = this.form.value as UserRegistrationModel;

    this.authService.register(model).subscribe(
      () => {
        this.router.navigate(['/login']);
      },
      (error: any) => {
        this.errorMessages = Object.keys(error.error).map(
          message => error.error[message]
        );
      }
    );
  }
}

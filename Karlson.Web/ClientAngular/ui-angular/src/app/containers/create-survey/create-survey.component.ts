import { Component, OnInit } from "@angular/core";
import { FormGroup, FormArray, FormControl, Validators } from "@angular/forms";

@Component({
  selector: "app-create-survey",
  templateUrl: "./create-survey.component.html",
  styleUrls: ["./create-survey.component.scss"]
})
export class CreateSurveyComponent implements OnInit {
  form = new FormGroup({
    name: new FormControl("", [Validators.required]),
    questions: new FormArray([
      new FormGroup({
        text: new FormControl(""),
        type: new FormControl("1"),
        options: new FormArray([new FormControl(""), new FormControl("")])
      })
    ])
  });

  constructor() {}

  ngOnInit() {}

  addQuestion() {
    const questions = this.form.controls.questions as FormArray;
    questions.push(
      new FormGroup({
        text: new FormControl(""),
        type: new FormControl("1"),
        options: new FormArray([new FormControl(""), new FormControl("")])
      })
    );
  }

  addAnswerOption(question: FormGroup) {
    const options = question.controls.options as FormArray;
    options.push(new FormControl(""));
  }

  onSubmit() {
    alert("submit");
  }

  get surveyName(): string {
    return this.form.controls.name.value;
  }

  get questions() {
    return this.form.get("questions") as FormArray;
  }
}

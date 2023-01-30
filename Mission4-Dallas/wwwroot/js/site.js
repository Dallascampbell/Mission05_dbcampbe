$("#btnCalc").click(function () {
  var letterGrade = "A";
  var numericGrade = 0;


  //Calculate Final Grade Percentage
  numericGrade = ($("#Assignments").val() * .5) + ($("#Project").val() * .1) + ($("#Quizzes").val() * .1);
  numericGrade = numericGrade + ($("#Midterm").val() * .1) + ($("#Final").val() * .1) + ($("#INTEX").val() * .1);


  //Determine what Letter Grade they will receive based on percentage
  if (numericGrade >= 94) {
    letterGrade = "A";
  }
  else if (numericGrade >= 90) {
    letterGrade = "A-";
  }
  else if (numericGrade >= 87) {
    letterGrade = "B+";
  }
  else if (numericGrade >= 84) {
    letterGrade = "B";
  }
  else if (numericGrade >= 80) {
    letterGrade = "B-";
  }
  else if (numericGrade >= 77) {
    letterGrade = "C+";
  }
  else if (numericGrade >= 74) {
    letterGrade = "C";
  }
  else if (numericGrade >= 70) {
    letterGrade = "C-";
  }
  else if (numericGrade >= 67) {
    letterGrade = "D-";
  }
  else if (numericGrade >= 64) {
    letterGrade = "D";
  }
  else if (numericGrade >= 60) {
    letterGrade = "D-";
  }
  else {
    letterGrade = "E";
  }

  //Print the letter grade back to the HTML file in the form
  $("#printGrade").html(letterGrade);
})

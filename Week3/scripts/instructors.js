var instructors =
  '{"instructors": [{"firstName": "Jimmy", "middleI": "A.", "lastName" : "Handel"}, {"firstName": "Maria", "middleI": "P.", "lastName" : "Roland"}, {"firstName": "Steven", "middleI": "R.", "lastName" : "Loph"}]}';

function initInstructors() {
  var instructors = getInstructors();

  displayInstructors(instructors);
}

function getInstructors() {
  return JSON.parse(instructors);
}

function displayInstructors(instructors) {
  var tableRows = "";

  tableRows +=
    "<tr><th>" +
    "First Name" +
    "</th><th>" +
    "Middle Initial" +
    "</th><th>" +
    "Last Name" +
    "</th></tr>";

  for (i = 0; i < instructors.instructors.length; i++) {
    var firstName = instructors.instructors[i].firstName;
    var middleI = instructors.instructors[i].middleI;
    var lastName = instructors.instructors[i].lastName;
    tableRows +=
      "<tr><td>" +
      firstName +
      "</td><td>" +
      middleI +
      "</td><td>" +
      lastName +
      "</td></tr>";
  }
  document.getElementById("instructor-table").innerHTML = tableRows;
}

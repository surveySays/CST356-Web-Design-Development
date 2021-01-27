var students = '{"students": [{"email": "studentone@oit.edu", "id": 8729374}, {"email": "studenttwo@oit.edu", "id": 2674928}]}'


function initStudednts() {
    var students = getStudents();

    displayStudents(students);
}

function getStudents() {
    return JSON.parse(students);
}

function displayStudents(students) {

    var tableRows = "";
    for (i = 0; i < students.length; i++) {
        var email = students[i].email;
        var id = students[i].id;
        tableRows += "<tr><td>" + email + "</td><td>" + id + "</td></tr>";
    }
    document.getElementById("student-table").innerHTML = tableRows ;
}

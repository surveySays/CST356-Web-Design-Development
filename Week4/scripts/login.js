function validate() {
  let username = document.getElementById("username");
  let password = document.getElementById("password");

  if (username.value == "") {
    username.style.border = "1px solid red";
    document.getElementById("username-title").style.color = "red";
    document.getElementById("username-title").innerHTML = "*Username";
  } else {
    username.style.border = "1px solid black";
    document.getElementById("username-title").style.color = "black";
    document.getElementById("username-title").innerHTML = "Username";
  }

  if (password.value == "") {
    password.style.border = "1px solid red";
    document.getElementById("password-title").style.color = "red";
    document.getElementById("password-title").innerHTML = "*Password";
  } else {
    password.style.border = "1px solid black";
    document.getElementById("password-title").style.color = "black";
    document.getElementById("password-title").innerHTML = "Password";
  }

  if (password.value != "" && username.value != "") {
    alert("Logging in!");
  }

  //document.cookie = `username=${firstName} ${lastName}; expires=31 Dec 2024 12:00:00 UTC; path=/`;
}

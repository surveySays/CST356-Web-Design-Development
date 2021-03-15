<template>
  <div>

    <h2 style="text-align: center;">Login Page</h2>

    <div id="form-log">
        <form>
            <label id="username-title" for="username">Username</label><br>
            <input type="text" id="username" name="username" value=""><br>
            <label id="password-title" for="password">Password</label><br>
            <input type="password" id="password" name="password" value=""><br><br>
            <input type="button" value="Login" v-on:click="validate()">
        </form> 
    </div>
         <!-- inject:js -->
        <!-- endinject -->
  </div>
</template>

<script>
export default {
  name: "Home",
  methods: {
      validate: function() {
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
          
}
}
};


</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
#menu-items {
  list-style-type: none;
  text-decoration: none;
  color: #ffffff;
  font-size: 20px;
  padding: 5px;
}

#menu-items a {
  list-style-type: none;
  text-decoration: none;
  color: #000000;
  font-size: 20px;
  padding: 5px;
}

a:hover {
  background-color: yellow;
  border-radius: 2px;
  padding: 5px;
}

#menu {
  display: flex;
  justify-content: space-around;
  height: 100%;
  margin-top: -8px;
}

#big-button {
  margin-top: auto;
  margin-bottom: auto;
  align-items: center;
  align-content: center;
}

#form-log {
  width: 100%;
  justify-content: center;
  display: flex;
  text-align: center;
}

#username {
  border: 1px solid black;
}

#password {
  border: 1px solid black;
}

table {
  font-family: arial, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

#index-heading {
  color: rgb(14, 41, 116);
  font-size: 24px;
}



</style>

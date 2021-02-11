<template>
    <div
      style="width:100% + 16px; height: 50px; background-color: tomato; margin-left: -8px; margin-right: -8px;"
    >
      <ul id="menu">
        <div id="big-button" v-on:click='goToForms'>
          <li id="menu-items">Instructor</li>
        </div>

        <div id="big-button" v-on:click='goToTables'>
          <li id="menu-items">Student</li>
        </div>
        <div id="big-button" v-on:click='goToHome'>
          <li id="menu-items">Home</li>
        </div>
         <div id="big-button" v-on:click='goToLogin'>
          <li id="menu-items">Login</li>
        </div>
      </ul>
    </div>

</template>

<script>
  export default {
    name: 'NavBar',
    methods: {
      goToHome: function() {
        this.$router.push({ path: 'home' })
      },
      goToTables: function() {
        this.$router.push({ path: 'students' })
      },
      goToForms: function() {
        this.$router.push({ path: 'Instructors' })
      },
       goToLogin: function() {
        this.$router.push({ path: 'Login' })
      }
    }
  }
</script>

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
  cursor: pointer;
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
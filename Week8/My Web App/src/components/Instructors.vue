<template>
  <div>

  <h2>Instructor Page</h2>


  <table id="student-table">
      <th>First Name</th>
      <th>Middle Initial</th>
      <th>LastName</th>
     <tr v-for="instructor in instructors" v-bind:key="instructor">
                    <td>{{ instructor.firstName }}</td>
                    <td>{{ instructor.middleI }}</td>
                    <td>{{ instructor.lastName }}</td>
                </tr>
  </table>

             <!-- inject:js -->
        <!-- endinject -->
  </div>
</template>

<script>


export default {
  name: "Instructors",
   mounted() {
            this.instructors = getInstructors();
        },
        data () {
            return {
                instructors: []
            }
        }

};

var instructors = '[{"firstName": "Jimmy", "middleI": "A.", "lastName" : "Handel"}, {"firstName": "Maria", "middleI": "P.", "lastName" : "Roland"}, {"firstName": "Steven", "middleI": "R.", "lastName" : "Loph"}]';

function getInstructors() {
  return JSON.parse(instructors);
}
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

 table, td {
        padding: 10px;
        border: 1px solid black; 
        border-collapse: collapse;
        text-align: left;
    }

th {
    text-align: left;
    border-collapse: collapse;
    padding: 10px;
    border: 1px solid black; 
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

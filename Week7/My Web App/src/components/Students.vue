<template>
  <div>


  <h2>Student Page</h2>

  <table id="student-table">
      <th>Student Email</th>
      <th>Student ID</th>
     <tr v-for="student in students" v-bind:key="student.studentId">
                    <td>{{ student.email }}</td>
                    <td>{{ student.id }}</td>
                </tr>
  </table>



         <!-- inject:js -->
        <!-- endinject -->
  </div>
</template>

<script>
import Vue from 'vue';
    export default {
        name: 'Students',
        
        data () {
            return {
                students: [],
                operation: 'list',
                email: undefined,
                studentId: undefined,
                // count: undefined,
                // productUpdateId: undefined,
                apiServer: process.env.VUE_APP_API_SERVER
            }
        },
        methods: {
            getSudents: function() {
                let url = `http://${this.apiServer}/api/student`;
                Vue.axios.get(url).then(
                    (response) => {
                        this.students = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },
            getProduct: function(studentId) {
                let url = `http://${this.apiServer}/api/product/${studentId}`;
                Vue.axios.get(url).then(
                    (response) => {
                        this.email = response.data.email;
                        this.studentId = response.data.studentId;
                        // this.count = response.data.count;
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },
            cancel: function() {
                this.operation = 'list';
            }
        },
        mounted() {
            this.getSudents();
            // this.operation = 'list';
        }
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
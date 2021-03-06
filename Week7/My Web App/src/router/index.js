import Vue from 'vue';
import Router from 'vue-router';
import Home from '@/components/Home';
import Students from '@/components/Students';
import Instructors from '@/components/Instructors';
import Login from '@/components/Login';


Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      component: Home
    },
    {
      path: '/home',
      component: Home
    },
    {
      path: '/students',
      component: Students
    },
    {
      path: '/instructors',
      component: Instructors
    },
    {
        path: '/login',
        component: Login
      }
  ]
})
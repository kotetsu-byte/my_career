import { createRouter, createWebHistory } from 'vue-router'
import Register from '../views/Register.vue';
import Login from '../views/Login.vue';
import ResumeType from '../views/ResumeType.vue'
import Freelance from '../views/Freelance.vue'
import Company from '../views/Company.vue'
import Frame1 from '../components/templates/Frame1.vue';
import Frame2 from '../components/templates/Frame2.vue';
import Frame3 from '../components/templates/Frame3.vue';
import Frame4 from '../components/templates/Frame4.vue';
import Frame5 from '../components/templates/Frame5.vue';
import Frame6 from '../components/templates/Frame6.vue';

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'Register',
      component: Register
    },
    {
      path: '/login',
      name: 'Login',
      component: Login
    },
    {
      path: '/resume-type',
      name: 'Resume Type',
      component: ResumeType
    },
    {
      path: '/freelance',
      name: 'Freelance',
      component: Freelance
    },
    {
      path: '/company',
      name: 'Company',
      component: Company
    },
    {
      path: '/frame1',
      name: 'Frame 1',
      component: Frame1
    },
    {
      path: '/frame2',
      name: 'Frame 2',
      component: Frame2
    },
    {
      path: '/frame3',
      name: 'Frame 3',
      component: Frame3
    },
    {
      path: '/frame4',
      name: 'Frame 4',
      component: Frame4
    },
    {
      path: '/frame5',
      name: 'Frame 5',
      component: Frame5
    },
    {
      path: '/frame6',
      name: 'Frame 6',
      component: Frame6
    }
  ]
})

export default router

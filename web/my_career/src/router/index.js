import { createRouter, createWebHistory } from 'vue-router'
import Register from '../views/Register.vue';
import Login from '../views/Login.vue';
import ResumeType from '../views/ResumeType.vue'
import Freelance from '../views/Freelance.vue'
import Company from '../views/Company.vue'
import Ready from '../views/Ready.vue';
import Frame1 from '../components/templates/Frame1.vue';
import Frame2 from '../components/templates/Frame2.vue';
import Frame3 from '../components/templates/Frame3.vue';
import Frame4 from '../components/templates/Frame4.vue';
import Frame5 from '../components/templates/Frame5.vue';
import Frame6 from '../components/templates/Frame6.vue';
import CompanyFrame1 from '../components/company-templates/CompanyFrame1.vue';
import CompanyFrame2 from '../components/company-templates/CompanyFrame2.vue';
import CompanyFrame3 from '../components/company-templates/CompanyFrame3.vue';
import CompanyFrame4 from '../components/company-templates/CompanyFrame4.vue';
import CompanyFrame5 from '../components/company-templates/CompanyFrame5.vue';
import CompanyFrame6 from '../components/company-templates/CompanyFrame6.vue';
import CompanyReady from '../views/CompanyReady.vue';
import HomePage from '../views/HomePage.vue';
import MyResumes from '../views/MyResumes.vue';
import OpenResume from '../views/OpenResume.vue';

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'Login',
      component: Login
    },
    {
      path: '/register',
      name: 'Register',
      component: Register
    },
    {
      path: '/home',
      name: 'Home Page',
      component: HomePage
    },
    {
      path: '/my-resumes',
      name: 'My Resumes',
      component: MyResumes
    },
    {
      path: '/open-resume',
      name: 'Open Resume',
      component: OpenResume
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
      path: '/ready',
      name: 'Ready',
      component: Ready
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
    },
    {
      path: '/company-frame-1',
      name: 'Company Frame 1',
      component: CompanyFrame1
    },
    {
      path: '/company-frame-2',
      name: 'Company Frame 2',
      component: CompanyFrame2
    },
    {
      path: '/company-frame-3',
      name: 'Company Frame 3',
      component: CompanyFrame3
    },
    {
      path: '/company-frame-4',
      name: 'Company Frame 4',
      component: CompanyFrame4
    },
    {
      path: '/company-frame-5',
      name: 'Company Frame 5',
      component: CompanyFrame5
    },
    {
      path: '/company-frame-6',
      name: 'Company Frame 6',
      component: CompanyFrame6
    },
    {
      path: '/company-ready',
      name: 'Company Ready',
      component: CompanyReady
    }
  ]
})

export default router
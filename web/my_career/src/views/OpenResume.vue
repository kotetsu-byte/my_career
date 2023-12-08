<template>
    <div class="super-container">
        <div style="margin: 200px auto 0 auto;">
            <div style="text-align: center;">
                <button @click="donwload()">Download</button>
                <button @click="edit()">Edit</button>
                <button @click="del()">Delete</button>
            </div>
            <div v-if="resumeType === 'freelance'">
                <component 
                    :is="frameName"
                    :photo="resumeData.imageURL"
                    :firstName="resumeData.firstName"
                    :lastName="resumeData.lastName"
                    :email="resumeData.email"
                    :phoneNumber="resumeData.phoneNumber"
                    :country="resumeData.country"
                    :region="resumeData.region"
                    :street="resumeData.street"
                    :position="resumeData.position"
                    :dateOfBirth="resumeData.dateOfBirth"
                    :skills="resumeData.skills"
                    :hobbies="resumeData.hobbies"
                    :selfDescription="resumeData.aboutSelf"
                    :languages="languageData"
                    :experience="experienceData"
                    :education="educationData"
                    :website="resumeData.website"
                    :whatsapp="resumeData.whatsapp"
                    :facebook="resumeData.facebook"
                    :instagram="resumeData.instagram"
                    :telegram="resumeData.telegram"
                    :github="resumeData.github"
                    :twitter="resumeData.twitter"
                ></component>
            </div>
            <div v-if="resumeType === 'company'">
                <component
                    :is="frameName"
                    :photo="companyResumeData.photo"
                    :companyName="companyResumeData.companyName"
                    :companyPhoneNumber="companyResumeData.companyPhoneNumber"
                    :address="companyResumeData.address"
                    :website="companyResumeData.website"
                    :whatsapp="companyResumeData.whatsapp"
                    :facebook="companyResumeData.facebook"
                    :instagram="companyResumeData.instagram"
                    :telegram="companyResumeData.telegram"
                    :github="companyResumeData.github"
                    :twitter="companyResumeData.twitter"
                    :description="companyResumeData.description"
                    :firstName="companyResumeData.firstName"
                    :lastName="companyResumeData.lastName"
                    :email="companyResumeData.email"
                    :phoneNumber="companyResumeData.phoneNumber"
                ></component>
            </div>
        </div>
    </div>
</template>

<script>
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
import { mapGetters, mapActions } from 'vuex';
import API from '../api';

export default {
    name: 'OpenResume',
    components: {Frame1, Frame2, Frame3, Frame4, Frame5, Frame6, CompanyFrame1, CompanyFrame2, CompanyFrame3, CompanyFrame4, CompanyFrame5, CompanyFrame6},
    data() {
        return {
            frameName: '',
            resumeType: '',
            resumeData: null,
            educationData: [],
            experienceData: [],
            languageData: [],
            companyResumeData: null
        }
    },
    props: {

    },
    methods: {
        ...mapActions([
            'setIsUpdate', 
            'setUpdateResume',
            'setUpdateEducation',
            'setUpdateExperience',
            'setUpdateLanguage',
            'setUpdateCompanyResume',
            'setSectionNo', 
            'removeAllUpdateEducation',
            'removeAllUpdateExperience',
            'setComponent1Data', 
            'setComponent2Data', 
            'setComponent3Data', 
            'setComponent4Data', 
            'setComponent5Data', 
            'setComponent6Data', 
            'setComponent7Data', 
            'setComponent8Data',
            'removeAllComponent5Data',
            'removeAllComponent6Data',
            'setCompanySectionNo',
            'setComapnyComponent1Data',
            'setComapnyComponent2Data',
            'setComapnyComponent3Data',
            'setComapnyComponent4Data',
            'setComapnyComponent5Data'
        ]),
        getResumeFromServer(obj) {
            switch(obj.type) {
                case 'freelance':
                    API.get(`/api/Resume/${obj.id}`)
                        .then(res => {
                            console.log(res.data);
                            this.structResume(res.data);
                        })
                        .catch(err => {
                            console.log(err);
                        })
                    API.get(`/api/Education/${obj.id}`)
                        .then(res => {
                            console.log(res.data);
                            this.structEducation(res.data);
                        })
                        .catch(err => {
                            console.log(err);
                        })
                    API.get(`/api/Experience/${obj.id}`)
                        .then(res => {
                            console.log(res.data);
                            this.structExperience(res.data);
                        })
                        .catch(err => {
                            console.log(err);
                        })
                    API.get(`/api/Language/${obj.id}`)
                        .then(res => {
                            console.log(res.data);
                            this.structLanguage(res.data);
                        })
                        .catch(err => {
                            console.log(err);
                        })
                    break;
                case 'company':
                API.get(`/api/CompanyResume/${obj.id}`)
                        .then(res => {
                            console.log(res.data);
                            this.structCompanyResume(res.data);
                        })
                        .catch(err => {
                            console.log(err);
                        })
                    break;
            }
        },
        structResume(obj) {
            switch(obj.templateNo) {
                case 1:
                    this.frameName = 'Frame1';
                    break;
                case 2:
                    this.frameName = 'Frame2';
                    break;
                case 3:
                    this.frameName = 'Frame3';
                    break;
                case 4:
                    this.frameName = 'Frame4';
                    break;
                case 5:
                    this.frameName = 'Frame5';
                    break;
                case 6:
                    this.frameName = 'Frame6';
                    break;
            }
            this.resumeData = obj;
            console.log(this.resumeData);
        },
        structEducation(obj) {
            obj.forEach(elem => {
                this.educationData.push(elem);
            })
            console.log(this.educationData);
        },
        structExperience(obj) {
            this.experienceData = obj;
            console.log(this.experienceData);
        },
        structLanguage(obj) {
            this.languageData = obj;
            console.log(this.languageData);
        },
        structCompanyResume(obj) {
            switch(obj.templateNo) {
                case 1:
                    this.frameName = 'CompanyFrame1';
                    break;
                case 2:
                    this.frameName = 'CompanyFrame2';
                    break;
                case 3:
                    this.frameName = 'CompanyFrame3';
                    break;
                case 4:
                    this.frameName = 'CompanyFrame4';
                    break;
                case 5:
                    this.frameName = 'CompanyFrame5';
                    break;
                case 6:
                    this.frameName = 'CompanyFrame6';
                    break;
            }
            this.companyResumeData = obj;
            console.log(this.companyResumeData);
        },
        donwload() {

        },
        edit() {
            this.setIsUpdate(true);
            switch(this.resumeType) {
                case 'freelance':
                    this.setUpdateResume(this.resumeData);
                    this.setUpdateEducation(this.educationData);
                    this.setUpdateExperience(this.experienceData);
                    this.setUpdateLanguage(this.languageData);
                    let comp1Obj = {
                        photo: this.resumeData.imageURL,
                        firstName: this.resumeData.firstName,
                        lastName: this.resumeData.lastName,
                        email: this.resumeData.email,
                        phoneNumber: this.resumeData.phoneNumber
                    }
                    this.setComponent1Data(comp1Obj);
                    let comp2Obj = {
                        country: this.resumeData.country,
                        region: this.resumeData.region,
                        street: this.resumeData.street
                    }
                    this.setComponent2Data(comp2Obj);
                    let comp3Obj = {
                        position: this.resumeData.position,
                        dateOfBirth: this.resumeData.dateOfBirth,
                        skills: this.resumeData.skills,
                        hobbies: this.resumeData.hobbies,
                        selfDescription: this.resumeData.aboutSelf
                    }
                    this.setComponent3Data(comp3Obj);
                    this.setComponent4Data(this.languageData);
                    this.removeAllComponent5Data();
                    this.experienceData.forEach(elem => {
                        this.setComponent5Data(elem);
                    })
                    this.removeAllComponent6Data();
                    this.educationData.forEach(elem => {
                        this.setComponent6Data(elem);
                    })
                    let comp7Obj = {
                        website: this.resumeData.website,
                        whatsapp: this.resumeData.whatsapp,
                        facebook: this.resumeData.facebook,
                        instagram: this.resumeData.instagram,
                        telegram: this.resumeData.telegram,
                        github: this.resumeData.github,
                        twitter: this.resumeData.twitter,
                    }
                    this.setComponent7Data(comp7Obj);
                    let comp8Obj = {
                        selectedTemplate: this.resumeData.templateNo
                    }
                    this.setComponent8Data(comp8Obj);
                    this.setSectionNo(1);
                    this.$router.push('/freelance')
                    break;
                case 'company:':
                    this.setUpdateCompanyResume(this.companyResumeData);
                    let company1Obj = {
                        firstName: this.companyResumeData.firstName,
                        lastName: this.companyResumeData.lastName,
                        email: this.companyResumeData.email,
                        phoneNumber: this.companyResumeData.phoneNumber,
                    }
                    this.setComapnyComponent1Data(company1Obj);
                    let company2Obj = {
                        photo: this.companyResumeData.photo,
                        companyName: this.companyResumeData.companyName,
                        companyPhoneNumber: this.companyResumeData.companyPhoneNumber
                    }
                    this.setComapnyComponent2Data(company2Obj);
                    let company3Obj = {
                        address: this.companyResumeData.address,
                        description: this.companyResumeData.description
                    }
                    this.setComapnyComponent3Data(company3Obj);
                    let company4Obj = {
                        website: this.companyResumeData.website,
                        whatsapp: this.companyResumeData.whatsapp,
                        facebook: this.companyResumeData.facebook,
                        instagram: this.companyResumeData.instagram,
                        telegram: this.companyResumeData.telegram,
                        github: this.companyResumeData.github,
                        twitter: this.companyResumeData.twitter
                    }
                    this.setComapnyComponent4Data(company4Obj);
                    let company5Obj = {
                        selectedTemplate: this.companyResumeData.templateNo
                    }
                    this.setComapnyComponent5Data(company5Obj);
                    this.setCompanySectionNo(1);
                    this.router.push('/company');
                    break;
            }
        },
        del() {
            switch(this.resumeType) {
                case 'freelance':
                    API.delete(`api/Resume/${this.resumeData.id}`)
                        .then(res => {
                            console.log(res.data);
                            this.$router.push('/my-resumes');
                        }).catch(err => {
                            console.log(err);
                        })
                    break;
                case 'company':
                    API.delete(`api/CompanyResume/${this.companyResumeData.id}`)
                        .then(res => {
                            console.log(res.data);
                            this.$router.push('/my-resumes');
                        }).catch(err => {
                            console.log(err);
                        })
                    break;
            }
        }
    },
    watch: {

    },
    computed: {
        ...mapGetters(['getOpenResume']),
        takeOpenResume() {
            this.getResumeFromServer(this.getOpenResume);
            this.resumeType = this.getOpenResume.type;
        }
    },
    mounted() {
        this.takeOpenResume;
    }
}
</script>

<style scoped>
.flex-div {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
}
.super-container {
    padding-top: 200px;
    width: 100%;
    background: url(../assets/img/logo.png) no-repeat;
    height: 100vh;
}
</style>    
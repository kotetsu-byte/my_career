<template>
    <div class="super-container">
        <div style="margin: auto; width: 50%;">
            <p style="font-size: 50px; font-weight: 700; text-align: center;">Your Resume<br> is Done!</p>
            <div style="background-color: white; background-image: none;">
                <component 
                    :is="frameName"
                    :photo="getCompanyComponent2Data.photo"
                    :companyName="getCompanyComponent2Data.companyName"
                    :companyPhoneNumber="getCompanyComponent2Data.companyPhoneNumber"
                    :address="getCompanyComponent3Data.address"
                    :website="getComponent4Data.website"
                    :whatsapp="getComponent4Data.whatsapp"
                    :facebook="getComponent4Data.facebook"
                    :instagram="getComponent4Data.instagram"
                    :telegram="getComponent4Data.telegram"
                    :github="getComponent4Data.github"
                    :twitter="getComponent4Data.twitter"
                    :description="getCompanyComponent3Data.description"
                    :firstName="getCompanyComponent1Data.firstName"
                    :lastName="getCompanyComponent1Data.lastName"
                    :email="getCompanyComponent1Data.email"
                    :phoneNumber="getCompanyComponent1Data.phoneNumber"
                ></component>
            </div>
        </div>
        <div style="float: right; text-align: center; width: 20%;">
            <button @click="sendDataToBackend()">Finish</button>
        </div>
    </div>
</template>

<script>
import CompanyFrame1 from '../components/company-templates/CompanyFrame1.vue';
import CompanyFrame2 from '../components/company-templates/CompanyFrame2.vue';
import CompanyFrame3 from '../components/company-templates/CompanyFrame3.vue';
import CompanyFrame4 from '../components/company-templates/CompanyFrame4.vue';
import CompanyFrame5 from '../components/company-templates/CompanyFrame5.vue';
import CompanyFrame6 from '../components/company-templates/CompanyFrame6.vue';
import { mapGetters } from 'vuex';
import API from '../api/index.js';

export default {
    name: 'CompanyReady',
    components: {CompanyFrame1, CompanyFrame2, CompanyFrame3, CompanyFrame4, CompanyFrame5, CompanyFrame6},
    data() {
        return {
            frameName: '',
            userId: '',
            template: {
                photo: "",
                companyName: "",
                companyPhoneNumber: "",
                address: "",
                website: "",
                whatsapp: "",
                facebook: "",
                instagram: "",
                telegram: "",
                github: "",
                twitter: "",
                description: "",
                firstName: "",
                lastName: "",
                email: "",
                phoneNumber: ""
            }
        }
    },
    methods: {
        displayData() {
            if(this.getIsUpdate === false) {
                this.template.photo = this.getCompanyComponent2Data.photo;
                this.template.companyName = this.getCompanyComponent2Data.companyName;
                this.template.companyPhoneNumber = this.getCompanyComponent2Data.companyPhoneNumber;
                this.template.address = this.getCompanyComponent3Data.description;
                this.template.website = this.getCompanyComponent4Data.website;
                this.template.whatsapp = this.getCompanyComponent4Data.whatsapp;
                this.template.facebook = this.getCompanyComponent4Data.facebook;
                this.template.instagram = this.getCompanyComponent4Data.instagram;
                this.template.telegram = this.getCompanyComponent4Data.telegram;
                this.template.github = this.getCompanyComponent4Data.github;
                this.template.twitter = this.getCompanyComponent4Data.twitter;
                this.template.description = this.getCompanyComponent3Data.description;
                this.template.firstName = this.getCompanyComponent1Data.firstName;
                this.template.lastName = this.getCompanyComponent1Data.lastName;
                this.template.email = this.getCompanyComponent1Data.email;
                this.template.phoneNumber = this.getCompanyComponent1Data.phoneNumber;
            } else {
                this.template.photo = this.getUpdateCompanyResume.photo;
                this.template.companyName = this.getUpdateCompanyResume.companyName;
                this.template.companyPhoneNumber = this.getUpdateCompanyResume.companyPhoneNumber;
                this.template.address = this.getUpdateCompanyResume.description;
                this.template.website = this.getUpdateCompanyResume.website;
                this.template.whatsapp = this.getUpdateCompanyResume.whatsapp;
                this.template.facebook = this.getUpdateCompanyResume.facebook;
                this.template.instagram = this.getUpdateCompanyResume.instagram;
                this.template.telegram = this.getUpdateCompanyResume.telegram;
                this.template.github = this.getUpdateCompanyResume.github;
                this.template.twitter = this.getUpdateCompanyResume.twitter;
                this.template.description = this.getUpdateCompanyResume.description;
                this.template.firstName = this.getUpdateCompanyResume.firstName;
                this.template.lastName = this.getUpdateCompanyResume.lastName;
                this.template.email = this.getUpdateCompanyResume.email;
                this.template.phoneNumber = this.getUpdateCompanyResume.phoneNumber;
            }
        },
        getFrameByNo(number) {
            console.log(number);
            switch(number) {
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
        },
        sendDataToBackend() {
            let obj = 
            {
                photo: this.getCompanyComponent2Data.photo,
                companyName: this.getCompanyComponent2Data.companyName,
                companyPhoneNumber: this.getCompanyComponent2Data.companyPhoneNumber,
                address: this.getCompanyComponent3Data.address,
                description: this.getCompanyComponent3Data.description,
                firstName: this.getCompanyComponent1Data.firstName,
                lastName: this.getCompanyComponent1Data.lastName,
                email: this.getCompanyComponent1Data.email,
                phoneNumber: this.getCompanyComponent1Data.phoneNumber,
                website: this.getCompanyComponent4Data.website,
                whatsapp: this.getCompanyComponent4Data.whatsapp,
                facebook: this.getCompanyComponent4Data.facebook,
                instagram: this.getCompanyComponent4Data.instagram,
                telegram: this.getCompanyComponent4Data.telegram,
                github: this.getCompanyComponent4Data.github,
                twitter: this.getCompanyComponent4Data.twitter,
                templateNo: this.getCompanyComponent5Data.selectedTemplate
            }
            switch(this.getIsUpdate) {
                case false:
                    API.post(`/api/CompanyResume/${this.userEmail}`, obj)
                        .then(res => {
                            console.log(res.data);
                        })
                        .catch(err => {
                            console.log(err);
                        });
                case true:
                    obj.id = this.getUpdateCompanyResumeId;
                    API.post(`/api/Resume/Update`, obj)
                        .then(res => {
                            console.log(res.data)
                        })
                        .catch(err => {
                            console.log(err);
                        })
            }
            
        }
    },
    computed: {
        ...mapGetters([
            'getIsUpdate',
            'getCurrentUser',
            'getUpdateCompanyResume', 
            'getCompanyComponent1Data', 
            'getCompanyComponent2Data', 
            'getCompanyComponent3Data', 
            'getCompanyComponent4Data', 
            'getCompanyComponent5Data'
        ]),
        getCompanyComponentsData() {
            this.getFrameByNo(this.getCompanyComponent5Data.selectedTemplate);
            this.userId = this.getCurrentUser.id;
            this.displayData();
            console.log(this.getCompanyComponent5Data);
        }
    },
    mounted() {
        this.getCompanyComponentsData;
    }
}
</script>

<style scoped>
.super-container {
    padding-top: 200px;
    width: 100%;
    background: url(../assets/img/logo.png) no-repeat;
}
</style>
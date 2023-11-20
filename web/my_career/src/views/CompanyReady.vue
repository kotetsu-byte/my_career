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
            userEmail: ''
        }
    },
    methods: {
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
            'getUpdateCompanyResumeId', 
            'getCompanyComponent1Data', 
            'getCompanyComponent2Data', 
            'getCompanyComponent3Data', 
            'getCompanyComponent4Data', 
            'getCompanyComponent5Data'
        ]),
        getCompanyComponentsData() {
            this.getFrameByNo(this.getCompanyComponent5Data.selectedTemplate);
            this.userEmail = this.getCurrentUser;
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
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
                    :contacts="getCompanyComponent4Data"
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
import Frame1 from '../components/company-templates/Frame1.vue';
import Frame2 from '../components/company-templates/Frame2.vue';
import Frame3 from '../components/company-templates/Frame3.vue';
import Frame4 from '../components/company-templates/Frame4.vue';
import Frame5 from '../components/company-templates/Frame5.vue';
import Frame6 from '../components/company-templates/Frame6.vue';
import { mapGetters } from 'vuex';
import API from '../api/index.js';

export default {
    name: 'CompanyReady',
    components: {Frame1, Frame2, Frame3, Frame4, Frame5, Frame6},
    data() {
        return {
            frameName: '',
        }
    },
    methods: {
        getFrameByNo(number) {
            console.log(number);
            switch(number) {
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
        },
        sendDataToBackend() {
            let obj = 
            {
                firstName: this.getCompanyComponent1Data.firstName,
                lastName: this.getCompanyComponent1Data.lastName,
                email: this.getCompanyComponent1Data.email,
                phoneNumber: this.getCompanyComponent1Data.phoneNumber,
                imageURL: this.getCompanyComponent1Data.photo,
                country: this.getCompanyComponent2Data.country,
                region: this.getCompanyComponent2Data.region,
                street: this.getCompanyComponent2Data.street,
                position: this.getCompanyComponent3Data.position,
                dateOfBirth: this.getCompanyComponent3Data.dateOfBirth,
                skills: this.getCompanyComponent3Data.skills,
                hobbies: this.getCompanyComponent3Data.hobbies,
                aboutSelf: this.getCompanyComponent3Data.selfDescription,
                templateNo: this.getCompanyComponent8Data.selectedTemplate,
            }
            API.post('/api/F', obj)
                .then(res => {
                    console.log(res.data);
                })
                .catch(err => {
                    console.log(err);
                });
        }
    },
    computed: {
        ...mapGetters(['getCompanyComponent1Data', 'getCompanyComponent2Data', 'getCompanyComponent3Data', 'getCompanyComponent4Data', 'getCompanyComponent5Data']),
        getCompanyComponentsData() {
            this.getFrameByNo(this.getCompanyComponent5Data.selectedTemplate);
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
<template>
    <div class="super-container">
        <div style="margin: auto; width: 50%;">
            <p style="font-size: 50px; font-weight: 700; text-align: center;">Your Resume<br> is Done!</p>
            <div style="background-color: white; background-image: none;">
                <component 
                    :is="frameName"
                    :photo="getComponent1Data.photo"
                    :firstName="getComponent1Data.firstName"
                    :lastName="getComponent1Data.lastName"
                    :email="getComponent1Data.email"
                    :phoneNumber="getComponent1Data.phoneNumber"
                    :country="getComponent2Data.country"
                    :region="getComponent2Data.region"
                    :street="getComponent2Data.street"
                    :position="getComponent3Data.position"
                    :dateOfBirth="getComponent3Data.dateOfBirth"
                    :skills="getComponent3Data.skills"
                    :hobbies="getComponent3Data.hobbies"
                    :selfDescription="getComponent3Data.selfDescription"
                    :languages="getComponent4Data"
                    :experience="getComponent5Data"
                    :education="getComponent6Data"
                    :website="getComponent7Data.website"
                    :whatsapp="getComponent7Data.whatsapp"
                    :facebook="getComponent7Data.facebook"
                    :instagram="getComponent7Data.instagram"
                    :telegram="getComponent7Data.telegram"
                    :github="getComponent7Data.github"
                    :twitter="getComponent7Data.twitter"
                ></component>
            </div>
        </div>
        <div style="float: right; text-align: center; width: 20%;">
            <button @click="sendDataToBackend()">Finish</button>
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
import { mapGetters } from 'vuex';
import API from '../api/index.js';

export default {
    name: 'Ready',
    components: {Frame1, Frame2, Frame3, Frame4, Frame5, Frame6},
    data() {
        return {
            frameName: '',
            userId: 0
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
            let resumeObj = 
            {
                firstName: this.getComponent1Data.firstName,
                lastName: this.getComponent1Data.lastName,
                email: this.getComponent1Data.email,
                phoneNumber: this.getComponent1Data.phoneNumber,
                imageURL: this.getComponent1Data.photo,
                country: this.getComponent2Data.country,
                region: this.getComponent2Data.region,
                street: this.getComponent2Data.street,
                position: this.getComponent3Data.position,
                dateOfBirth: this.getComponent3Data.dateOfBirth,
                skills: this.getComponent3Data.skills,
                hobbies: this.getComponent3Data.hobbies,
                aboutSelf: this.getComponent3Data.selfDescription,
                templateNo: this.getComponent8Data.selectedTemplate,
                website: this.getComponent7Data.website,
                whatsapp: this.getComponent7Data.whatsapp,
                facebook: this.getComponent7Data.facebook,
                instagram: this.getComponent7Data.instagram,
                telegram: this.getComponent7Data.telegram,
                github: this.getComponent7Data.github,
                twitter: this.getComponent7Data.twitter,
                userId: this.userId
            }
            let educationObj = this.getComponent6Data;
            let experienceObj = this.getComponent5Data;
            let languageObj = this.getComponent4Data;
            switch(this.getIsUpdate) {
                case false:
                API.post(`/api/Resume/`, resumeObj)
                    .then(res => {
                        let resumeId = res.data;
                        educationObj.forEach(education => {
                            education.resumeId = resumeId;
                            API.post(`/api/Education/`, education)
                            .then(res => {
                                console.log(res.data)
                            })
                            .catch(err => {
                                console.log(err);
                            });
                        });
                        experienceObj.forEach(experience => {
                            experience.resumeId = resumeId;
                            API.post(`/api/Experience/`, experience)
                                .then(res => {
                                    console.log(res.data);
                                })
                                .catch(err => {
                                    console.log(err);
                                })    
                        })
                        languageObj.forEach(language => {
                            language.resumeId = resumeId;
                            API.post(`/api/Language/`, language)
                                .then(res => {
                                    console.log(res.data);
                                })
                                .catch(err => {
                                    console.log(err);
                                })
                        })
                    })
                    .catch(err => {
                        console.log(err);
                    });
                    break;
                case true:
                    resumeObj.id = this.getUpdateResume.id;
                    console.log(resumeObj);
                    API.post(`/api/Resume/Update`, resumeObj)
                        .then(res => {
                            console.log(res.data);
                            for(let i = 0; i < this.getUpdateEducation.length; i++)
                            {
                                educationObj[i].id = this.getUpdateEducation[i].id;
                                API.post(`/api/Education/Update`, educationObj[i])
                                .then(res => {
                                    console.log(res.data)
                                })
                                .catch(err => {
                                    console.log(err);
                                });
                            }
                            for(let i = 0; i < this.getUpdateExperience.length; i++)
                            {
                                experienceObj[i].id = this.getUpdateExperience[i].id;
                                API.post(`/api/Experience/Update`, experienceObj[i])
                                .then(res => {
                                    console.log(res.data)
                                })
                                .catch(err => {
                                    console.log(err);
                                });
                            }
                            for(let i = 0; i < this.getUpdateLanguage.length; i++)
                            {
                                languageObj[i].id = this.getUpdateLanguage[i].id;
                                API.post(`/api/Language/Update`, languageObj[i])
                                .then(res => {
                                    console.log(res.data)
                                })
                                .catch(err => {
                                    console.log(err);
                                });
                            }
                        })
                        .catch(err => {
                            console.log(err);
                        });
                    break;
            }
        }
    },
    computed: {
        ...mapGetters([
            'getIsUpdate', 
            'getUpdateResume',
            'getUpdateEducation',
            'getUpdateExperience',
            'getUpdateLanguage', 
            'getCurrentUser', 
            'getComponent1Data', 
            'getComponent2Data', 
            'getComponent3Data', 
            'getComponent4Data', 
            'getComponent5Data', 
            'getComponent6Data', 
            'getComponent7Data', 
            'getComponent8Data'
        ]),
        getComponentsData() {
            this.getFrameByNo(this.getComponent8Data.selectedTemplate);
            this.userId = this.getCurrentUser;
            console.log(this.userId);
            console.log(this.getComponent5Data);
        }
    },
    mounted() {
        this.getComponentsData;
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
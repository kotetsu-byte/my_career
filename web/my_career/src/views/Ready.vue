<template>
    <div class="super-container">
        <div style="margin: auto; width: 50%;">
            <p style="font-size: 50px; font-weight: 700; text-align: center;">Your Resume<br> is Done!</p>
            <div style="background-color: white; background-image: none;">
                <component 
                    :is="frameName"
                    :photo="template.photo"
                    :firstName="template.firstName"
                    :lastName="template.lastName"
                    :email="template.email"
                    :phoneNumber="template.phoneNumber"
                    :country="template.country"
                    :region="template.region"
                    :street="template.street"
                    :position="template.position"
                    :dateOfBirth="template.dateOfBirth"
                    :skills="template.skills"
                    :hobbies="template.hobbies"
                    :aboutSelf="template.aboutSelf"
                    :languages="template.languages"
                    :experience="template.experience"
                    :education="template.education"
                    :website="template.website"
                    :whatsapp="template.whatsapp"
                    :facebook="template.facebook"
                    :instagram="template.instagram"
                    :telegram="template.telegram"
                    :github="template.github"
                    :twitter="template.twitter"
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
            userId: 0,
            template: {
                photo: '',
                firstName: '',
                lastName: '',
                email: '',
                phoneNumber: '',
                country: '',
                region: '',
                street: '',
                position: '',
                dateOfBirth: '',
                skills: '',
                hobbies: '',
                aboutSelf: '',
                languages: [],
                experience: [],
                education: [],
                website: '',
                whatsapp: '',
                facebook: '',
                instagram: '',
                telegram: '',
                github: '',
                twitter: '',
                selectedTemplate: 0
            }
        }
    },
    methods: {
        displayData() {
            if(this.getIsUpdate === false) {
                this.template.photo = this.getComponent1Data.photo;
                this.template.firstName = this.getComponent1Data.firstName;
                this.template.lastName = this.getComponent1Data.lastName;
                this.template.email = this.getComponent1Data.email;
                this.template.phoneNumber = this.getComponent1Data.phoneNumber;
                this.template.country = this.getComponent2Data.country;
                this.template.region = this.getComponent2Data.region;
                this.template.street = this.getComponent2Data.street;
                this.template.position = this.getComponent3Data.position;
                this.template.dateOfBirth = this.getComponent3Data.dateOfBirth;
                this.template.skills = this.getComponent3Data.skills;
                this.template.hobbies = this.getComponent3Data.hobbies;
                this.template.aboutSelf = this.getComponent3Data.aboutSelf;
                this.getComponent4Data.forEach(elem => {
                    this.template.languages.push(elem);
                });
                this.getComponent5Data.forEach(elem => {
                    this.template.experience.push(elem);
                });
                this.getComponent6Data.forEach(elem => {
                    this.template.education.push(elem);
                })
                this.template.website = this.getComponent7Data.website;
                this.template.whatsapp = this.getComponent7Data.whatsapp;
                this.template.facebook = this.getComponent7Data.facebook;
                this.template.instagram = this.getComponent7Data.instagram;
                this.template.telegram = this.getComponent7Data.telegram;
                this.template.github = this.getComponent7Data.github;
                this.template.twitter = this.getComponent7Data.twitter;
            } else {
                this.template.photo = this.getUpdateResume.photo;
                this.template.firstName = this.getUpdateResume.firstName;
                this.template.lastName = this.getUpdateResume.lastName;
                this.template.email = this.getUpdateResume.email;
                this.template.phoneNumber = this.getUpdateResume.phoneNumber;
                this.template.country = this.getUpdateResume.country;
                this.template.region = this.getUpdateResume.region;
                this.template.street = this.getUpdateResume.street;
                this.template.position = this.getUpdateResume.position;
                this.template.dateOfBirth = this.getUpdateResume.dateOfBirth;
                this.template.skills = this.getUpdateResume.skills;
                this.template.hobbies = this.getUpdateResume.hobbies;
                this.template.aboutSelf = this.getUpdateResume.aboutSelf;
                this.getUpdateLanguage.forEach(elem => {
                    this.template.languages.push(elem);
                });
                this.getUpdateExperience.forEach(elem => {
                    this.template.experience.push(elem);
                });
                this.getUpdateEducation.forEach(elem => {
                    this.template.education.push(elem);
                })
                this.template.website = this.getUpdateResume.website;
                this.template.whatsapp = this.getUpdateResume.whatsapp;
                this.template.facebook = this.getUpdateResume.facebook;
                this.template.instagram = this.getUpdateResume.instagram;
                this.template.telegram = this.getUpdateResume.telegram;
                this.template.github = this.getUpdateResume.github;
                this.template.twitter = this.getUpdateResume.twitter;
            }
        },
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
            switch(this.getIsUpdate) {
                case false:
                    var resumeObj = 
                    {
                        firstName: this.getComponent1Data.firstName,
                        lastName: this.getComponent1Data.lastName,
                        email: this.getComponent1Data.email,
                        phoneNumber: this.getComponent1Data.phoneNumber,
                        photo: this.getComponent1Data.photo,
                        country: this.getComponent2Data.country,
                        region: this.getComponent2Data.region,
                        street: this.getComponent2Data.street,
                        position: this.getComponent3Data.position,
                        dateOfBirth: this.getComponent3Data.dateOfBirth,
                        skills: this.getComponent3Data.skills,
                        hobbies: this.getComponent3Data.hobbies,
                        aboutSelf: this.getComponent3Data.aboutSelf,
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
                    var educationObj = this.getComponent6Data;
                    var experienceObj = this.getComponent5Data;
                    var languageObj = this.getComponent4Data;
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
                    var resumeObj = 
                    {
                        id: this.getUpdateResume.id,
                        firstName: this.getUpdateResume.firstName,
                        lastName: this.getUpdateResume.lastName,
                        email: this.getUpdateResume.email,
                        phoneNumber: this.getUpdateResume.phoneNumber,
                        photo: this.getUpdateResume.photo,
                        country: this.getUpdateResume.country,
                        region: this.getUpdateResume.region,
                        street: this.getUpdateResume.street,
                        position: this.getUpdateResume.position,
                        dateOfBirth: this.getUpdateResume.dateOfBirth,
                        skills: this.getUpdateResume.skills,
                        hobbies: this.getUpdateResume.hobbies,
                        aboutSelf: this.getUpdateResume.aboutSelf,
                        templateNo: this.getUpdateResume.selectedTemplate,
                        website: this.getUpdateResume.website,
                        whatsapp: this.getUpdateResume.whatsapp,
                        facebook: this.getUpdateResume.facebook,
                        instagram: this.getUpdateResume.instagram,
                        telegram: this.getUpdateResume.telegram,
                        github: this.getUpdateResume.github,
                        twitter: this.getUpdateResume.twitter,
                        userId: this.userId
                    }
                    var educationObj = this.getUpdateEducation;
                    var experienceObj = this.getUpdateExperience;
                    var languageObj = this.getUpdateLanguage;
                    console.log(resumeObj);
                    API.patch(`/api/Resume`, resumeObj)
                        .then(res => {
                            console.log(res.data);
                            let resumeId = res.data;
                            this.getUpdateEducation.forEach(elem => {
                                if((elem.id != 0) && elem.id) {
                                    API.patch(`/api/Education`, elem)
                                        .then(res => {
                                            console.log(res.data)
                                        })
                                        .catch(err => {
                                            console.log(err);
                                        });    
                                } else {
                                    elem.resumeId = res.data 
                                    API.post('/api/Education', elem)
                                        .then(res => {
                                            console.log(res.data);
                                        }).catch(err => {
                                            console.log(err);
                                        })
                                }
                            })
                            this.getUpdateExperience.forEach(elem => {
                                if((elem.id != 0) && elem.id) {
                                    API.patch(`/api/Experience`, elem)
                                        .then(res => {
                                            console.log(res.data)
                                        })
                                        .catch(err => {
                                            console.log(err);
                                        });
                                } else {
                                    elem.resumeId = resumeId;
                                    API.post(`/api/Experience`, elem)
                                        .then(res => {
                                            console.log(res.data)
                                        })
                                        .catch(err => {
                                            console.log(err);
                                        });
                                }
                            })
                            this.getUpdateLanguage.forEach(elem => {
                                if((elem.id != 0) && elem.id) {
                                    API.patch(`/api/Language`, elem)
                                        .then(res => {
                                            console.log(res.data)
                                        })
                                        .catch(err => {
                                            console.log(err);
                                        });
                                } else {
                                    elem.resumeId = resumeId;
                                    API.post(`/api/Language`, elem)
                                        .then(res => {
                                            console.log(res.data)
                                        })
                                        .catch(err => {
                                            console.log(err);
                                        });
                                }
                            })
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
            'getComponent8Data',
        ]),
        getComponentsData() {
            if(this.getIsUpdate === false) {
                this.getFrameByNo(this.getComponent8Data.selectedTemplate);
                this.template.selectedTemplate = this.getComponent8Data.selectedTemplate;
            } else {
                this.getFrameByNo(this.getUpdateResume.selectedTemplate);
                this.template.selectedTemplate = this.getUpdateResume.selectedTemplate;
            }
            this.userId = this.getCurrentUser;
            this.displayData();
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
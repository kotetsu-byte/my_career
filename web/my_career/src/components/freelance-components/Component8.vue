<template>
    <p style="font-size: 30px; font-weight: 700; margin: 10px 0;">Select you resume Design</p>
    <p style="font-size: 18px; font-weight: 500; color: #808080; margin: 10px 0;">Your resume is ready! You need to choose one of this templates and all your info will be filled in it already.</p>
    <div class="templates" style="display: flex; flex-direction: row; overflow-x: scroll;">
        <div class="frame" @click="select(1)" style="padding: 0;">
            <Frame1
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
                :selfDescription="template.selfDescription"
                :language="template.language"
                :level="template.level"
                :experience="template.experience"
                :education="template.education"
                :contacts="template.contacts"
            />
        </div>
        <div class="frame" @click="select(2)">
            <Frame2
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
                :selfDescription="template.selfDescription"
                :language="template.language"
                :level="template.level"
                :experience="template.experience"
                :education="template.education"
                :contacts="template.contacts"
            />
        </div>
        <div class="frame" @click="select(3)">
            <Frame3
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
                :selfDescription="template.selfDescription"
                :language="template.language"
                :level="template.level"
                :experience="template.experience"
                :education="template.education"
                :contacts="template.contacts"
            />
        </div>
        <div class="frame" @click="select(4)">
            <Frame4 
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
                :selfDescription="template.selfDescription"
                :language="template.language"
                :level="template.level"
                :experience="template.experience"
                :education="template.education"
                :contacts="template.contacts"
            />
        </div>
        <div class="frame" @click="select(5)">
            <Frame5 
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
                :selfDescription="template.selfDescription"
                :language="template.language"
                :level="template.level"
                :experience="template.experience"
                :education="template.education"
                :contacts="template.contacts"
            />
        </div>
        <div class="frame" @click="select(6)">
            <Frame6 
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
                :selfDescription="template.selfDescription"
                :language="template.language"
                :level="template.level"
                :experience="template.experience"
                :education="template.education"
                :contacts="template.contacts"
            />
        </div>
    </div>
</template>

<script>
import Frame1 from '../templates/Frame1.vue';
import Frame2 from '../templates/Frame2.vue';
import Frame3 from '../templates/Frame3.vue';
import Frame4 from '../templates/Frame4.vue';
import Frame5 from '../templates/Frame5.vue';
import Frame6 from '../templates/Frame6.vue';
import { mapActions, mapGetters } from 'vuex';

export default {
    name: 'Component8',
    components: {Frame1, Frame2, Frame3, Frame4, Frame5, Frame6},
    data() {
        return {
            selectedTemplate: 0,
            template: {
                photo: '../../src/assets/img/templates/frame-6-photo.png',
                firstName: 'John',
                lastName: 'Smith',
                email: 'user@name.com',
                phoneNumber: '+99890 000 00 00',
                country: 'Uzbekistan',
                region: 'Tashkent',
                street: 'Uchtepa Kocha-oqtepa pr3 344',
                position: 'Marketing Specialist',
                dateOfBirth: '',
                skills: 'Photoshop',
                hobbies: 'Travelling',
                selfDescription: 'In my current position at ABC, I have supervised all phases of our online marketing initiatives, both technical and creative. Last year, my key challeng was to design and optimize nine product websites for ABC\'s most strategic products and improve our SO results as well as enhance the UX. Here we are a year later:',
                language: 'English',
                level: 'level',
                experience: {
                    companyName: 'Company Name',
                    job: 'Senior UX Designer',
                    working: false,
                    from: '2020',
                    to: 'Present',
                    description: 'Lorem Ipsum Issyk simply dummy text offset the printing and typesetting industry.'
                },
                education: {
                    schoolName: 'University name',
                    degree: 'Degree Name',
                    typeOfStudy: 'Type of Study',
                    location: 'Location',
                    from: '2012',
                    to: '2014',
                    currently: false
                },
                contacts: 'Murphy_design_2001'
            }
        }
    },
    props: {
        saveToStore: Boolean
    },
    methods: {
        ...mapActions(['setComponent8Data']),
        select(num) {
            this.selectedTemplate = num;
            document.querySelectorAll('.frame').forEach(elem => {
                elem.classList.remove('selected');
            })
            document.querySelectorAll('.frame')[num - 1].classList.add('selected');
        },
        sendComponentDataToStore() {
            var obj = {
                selectedTemplate: this.selectedTemplate
            };
            this.setComponent8Data(obj);
            this.$emit('nextPrevPage', null);
        }
    },
    watch: {
        saveToStore: function(newVal, oldVal) {
            if(newVal == true) {
                this.sendComponentDataToStore();
            }
        }
    },
    computed: {
        ...mapGetters(['getComponent8Data']),
        getComponentData() {
            if(this.getComponent8Data)
            {
                this.selectedTemplate = this.getComponent8Data.selectedTemplate;
                console.log(this.selectedTemplate);
                if(parseInt(this.selectedTemplate) > 0) {
                    this.select(this.selectedTemplate);
                }    
            }
        }
    },
    mounted() {
        this.getComponentData;
    }
}
</script>

<style scoped>
.container {
    margin: 100px auto 0 auto;
    min-width: 400px;
    background-color: white;
    border-radius: 12px;
    padding: 20px;
    width: 40vw;
}

.flex-div {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
}

.grid-div {
    display: grid;
    grid-template-columns: 1fr 1fr 1fr;
}

.selected {
    border: 3px solid blue;
    background: grey;
}
</style>
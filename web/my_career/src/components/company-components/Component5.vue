<template>
     <p style="font-size: 30px; font-weight: 700; margin: 10px 0;">Select you resume Design</p>
    <p style="font-size: 18px; font-weight: 500; color: #808080; margin: 10px 0;">Your resume is ready! You need to choose one of this templates and all your info will be filled in it already.</p>
    <div class="templates" style="display: flex; flex-direction: row; overflow-x: scroll;">
        <div class="frame" @click="select(1)" style="padding: 0;">
            <CompanyFrame1
                :photo="template.photo"
                :companyName="template.companyName"
                :companyPhoneNumber="template.companyPhoneNumber"
                :address="template.address"
                :website="template.website"
                :whatsapp="template.whatsapp"
                :facebook="template.facebook"
                :instagram="template.instagram"
                :telegram="template.telegram"
                :github="template.github"
                :twitter="template.twitter"
                :description="template.description"
                :firstName="template.firstName"
                :lastName="template.lastName"
                :email="template.email"
                :phoneNumber="template.phoneNumber"
            />
        </div>
        <div class="frame" @click="select(2)">
            <CompanyFrame2
                :photo="template.photo"
                :companyName="template.companyName"
                :companyPhoneNumber="template.companyPhoneNumber"
                :address="template.address"
                :website="template.website"
                :whatsapp="template.whatsapp"
                :facebook="template.facebook"
                :instagram="template.instagram"
                :telegram="template.telegram"
                :github="template.github"
                :twitter="template.twitter"
                :description="template.description"
                :firstName="template.firstName"
                :lastName="template.lastName"
                :email="template.email"
                :phoneNumber="template.phoneNumber"
            />
        </div>
        <div class="frame" @click="select(3)">
            <CompanyFrame3
                :photo="template.photo"
                :companyName="template.companyName"
                :companyPhoneNumber="template.companyPhoneNumber"
                :address="template.address"
                :website="template.website"
                :whatsapp="template.whatsapp"
                :facebook="template.facebook"
                :instagram="template.instagram"
                :telegram="template.telegram"
                :github="template.github"
                :twitter="template.twitter"
                :description="template.description"
                :firstName="template.firstName"
                :lastName="template.lastName"
                :email="template.email"
                :phoneNumber="template.phoneNumber"
            />
        </div>
        <div class="frame" @click="select(4)">
            <CompanyFrame4 
                :photo="template.photo"
                :companyName="template.companyName"
                :companyPhoneNumber="template.companyPhoneNumber"
                :address="template.address"
                :website="template.website"
                :whatsapp="template.whatsapp"
                :facebook="template.facebook"
                :instagram="template.instagram"
                :telegram="template.telegram"
                :github="template.github"
                :twitter="template.twitter"
                :description="template.description"
                :firstName="template.firstName"
                :lastName="template.lastName"
                :email="template.email"
                :phoneNumber="template.phoneNumber"
            />
        </div>
        <div class="frame" @click="select(5)">
            <CompanyFrame5 
                :photo="template.photo"
                :companyName="template.companyName"
                :companyPhoneNumber="template.companyPhoneNumber"
                :address="template.address"
                :website="template.website"
                :whatsapp="template.whatsapp"
                :facebook="template.facebook"
                :instagram="template.instagram"
                :telegram="template.telegram"
                :github="template.github"
                :twitter="template.twitter"
                :description="template.description"
                :firstName="template.firstName"
                :lastName="template.lastName"
                :email="template.email"
                :phoneNumber="template.phoneNumber"
            />
        </div>
        <div class="frame" @click="select(6)">
            <CompanyFrame6 
                :photo="template.photo"
                :companyName="template.companyName"
                :companyPhoneNumber="template.companyPhoneNumber"
                :address="template.address"
                :website="template.website"
                :whatsapp="template.whatsapp"
                :facebook="template.facebook"
                :instagram="template.instagram"
                :telegram="template.telegram"
                :github="template.github"
                :twitter="template.twitter"
                :description="template.description"
                :firstName="template.firstName"
                :lastName="template.lastName"
                :email="template.email"
                :phoneNumber="template.phoneNumber"
            />
        </div>
    </div>
</template>

<script>
import CompanyFrame1 from '../company-templates/CompanyFrame1.vue';
import CompanyFrame2 from '../company-templates/CompanyFrame2.vue';
import CompanyFrame3 from '../company-templates/CompanyFrame3.vue';
import CompanyFrame4 from '../company-templates/CompanyFrame4.vue';
import CompanyFrame5 from '../company-templates/CompanyFrame5.vue';
import CompanyFrame6 from '../company-templates/CompanyFrame6.vue';
import {mapGetters, mapActions} from 'vuex';

export default {
    name: 'Component5',
    components: {CompanyFrame1, CompanyFrame2, CompanyFrame3, CompanyFrame4, CompanyFrame5, CompanyFrame6},
    data() {
        return {
            selectedTemplate: 0,
            template: {
                firstName: 'Alisher',
                lastName: 'Usmanov',
                email: 'gross.23.29.11@gmail.com',
                phoneNumber: '+998 90 000 00 00',
                photo: '../../src/assets/img/templates/frame-6-photo.png',
                companyName: 'NAPA',
                companyPhoneNumber: '+998 71 000 00 00',
                address: 'Somewhere',
                description: 'Something',
                website: '',
                whatsapp: '',
                facebook: '',
                instagram: '',
                telegram: '',
                github: '',
                twitter: ''
            }            
        }
    },
    props: {
        saveToStore: Boolean
    },
    methods: {
        ...mapActions(['setCompanyComponent5Data']),
        select(num) {
            this.selectedTemplate = num;
            document.querySelectorAll('.frame').forEach(elem => {
                elem.classList.remove('selected');
            })
            document.querySelectorAll('.frame')[num - 1].classList.add('selected');
        },
        sendComponentDataToStore() {
            let obj = {
                selectedTemplate: this.selectedTemplate
            };
            this.setCompanyComponent5Data(obj);
            this.$emit('nextPrevPage', null);
        }
    },
    watch: {
        saveToStore: function(newVal, oldVal) {
            if(newVal == true) {
                this.sendComponentDataToStore();
            }
        },
    },
    computed: {
        ...mapGetters(['getCompanyComponent5Data']),
        getCompanyData() {
            if(this.getCompanyComponent5Data)
            {
                this.selectedTemplate = this.getCompanyComponent5Data.selectedTemplate;
                console.log(this.selectedTemplate);
                if(parseInt(this.selectedTemplate) > 0) {
                    this.select(this.selectedTemplate);
                }    
            }
        }
    },
    mounted() {

    }
}
</script>

<style scoped>
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
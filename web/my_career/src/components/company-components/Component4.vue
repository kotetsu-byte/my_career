<template>
    <p style="font-size: 30px; font-weight: 700;">Contacts</p>
    <input v-model="website" type="url" style="border: 1px solid #CDCDCD; padding: 15px 20px; width: 90%; border-radius: 8px; font-size: 20px; font-weight: 500; margin: 10px 0;" placeholder="Provide a link to your website">
    <div v-for="(item, index) in chosen" :key="index">
        <input v-model="item.link" :class="item.name" type="text" :style="`background: url(${item.icon}) no-repeat center right`" style="border: 1px solid #CDCDCD; padding: 15px 20px; width: 80%; border-radius: 8px; font-size: 20px; font-weight: 500; margin: 10px 0;" :placeholder="`Provide a link to your ${item.name} account`"><button @click="removeInput(item.id)">X</button>
    </div>
    <p style="font-size: 18px; font-weight: 500; margin: 10px 0;">Choose in which of these social networks you have an account</p>
    <div class="grid-div" style="margin: 10px 0;">
        <div v-if="!whatsappIsChosen" id="whatsapp" @click="choose('whatsapp')" style="text-align: center; padding: 30px 44px; border-radius: 8px; box-shadow: 0px 2px 6px 0px rgba(0, 0, 0, 0.25);"><img src="../../assets/icons/contacts/whatsapp.png" alt=""><p style="font-size: 20px; font-weight: 600;">WhatsApp</p></div>
        <div v-if="!facebookIsChosen" id="facebook" @click="choose('facebook')" style="text-align: center; padding: 30px 44px; border-radius: 8px; box-shadow: 0px 2px 6px 0px rgba(0, 0, 0, 0.25);"><img src="../../assets/icons/contacts/facebook.png" alt=""><p style="font-size: 20px; font-weight: 600;">Facebook</p></div>
        <div v-if="!instagramIsChosen" id="instagram" @click="choose('instagram')" style="text-align: center; padding: 30px 44px; border-radius: 8px; box-shadow: 0px 2px 6px 0px rgba(0, 0, 0, 0.25);"><img src="../../assets/icons/contacts/instagram.png" alt=""><p style="font-size: 20px; font-weight: 600;">Instagram</p></div>
        <div v-if="!telegramIsChosen" id="telegram" @click="choose('telegram')" style="text-align: center; padding: 30px 44px; border-radius: 8px; box-shadow: 0px 2px 6px 0px rgba(0, 0, 0, 0.25);"><img src="../../assets/icons/contacts/telegram.png" alt=""><p style="font-size: 20px; font-weight: 600;">Telegram</p></div>
        <div v-if="!githubIsChosen" id="github" @click="choose('github')" style="text-align: center; padding: 30px 44px; border-radius: 8px; box-shadow: 0px 2px 6px 0px rgba(0, 0, 0, 0.25);"><img src="../../assets/icons/contacts/github.png" alt=""><p style="font-size: 20px; font-weight: 600;">Github</p></div>
        <div v-if="!twitterIsChosen" id="twitter" @click="choose('twitter')" style="text-align: center; padding: 30px 44px; border-radius: 8px; box-shadow: 0px 2px 6px 0px rgba(0, 0, 0, 0.25);"><img src="../../assets/icons/contacts/twitter.png" alt=""><p style="font-size: 20px; font-weight: 600;">Twitter</p></div>
    </div>
</template>

<script>
import {mapGetters, mapActions} from 'vuex';

export default {
    name: 'Component4',
    components: {},
    data() {
        return {
            website: '',
            chosen: [

            ],
            whatsappIsChosen: false,
            facebookIsChosen: false,
            instagramIsChosen: false,
            telegramIsChosen: false,
            githubIsChosen: false,
            twitterIsChosen: false,
        }
    },
    props: {
        saveToStore: Boolean
    },
    methods: {
        ...mapActions(['setCompanyComponent4Data']),
        choose(app) {
            switch(app) {
                case 'whatsapp':
                    let obj = {
                        id: 1,
                        name: 'whatsapp',
                        icon: '../../src/assets/icons/contacts/whatsapp.png',
                        link: ''
                    };
                    this.chosen.push(obj);
                    this.whatsappIsChosen = true;
                    break;
                case 'facebook':
                obj = {
                        id: 2,
                        name: 'facebook',
                        icon: '../../src/assets/icons/contacts/facebook.png',
                        link: ''
                    };
                    this.chosen.push(obj);
                    this.facebookIsChosen = true;
                    break;
                case 'instagram':
                obj = {
                        id: 3,
                        name: 'instagram',
                        icon: '../../src/assets/icons/contacts/instagram.png',
                        link: ''
                    };
                    this.chosen.push(obj);
                    this.instagramIsChosen = true;
                    break;
                case 'telegram':
                obj = {
                        id: 4,
                        name: 'telegram',
                        icon: '../../src/assets/icons/contacts/telegram.png',
                        link: ''
                    };
                    this.chosen.push(obj);
                    this.telegramIsChosen = true;
                    break;
                case 'github':
                obj = {
                        id: 5,
                        name: 'github',
                        icon: '../../src/assets/icons/contacts/github.png',
                        link: ''
                    };
                    this.chosen.push(obj);
                    this.githubIsChosen = true;
                    break;
                case 'twitter':
                obj = {
                        id: 6,
                        name: 'twitter',
                        icon: '../../src/assets/icons/contacts/twitter.png',
                        link: ''
                    };
                    this.chosen.push(obj);
                    this.twitterIsChosen = true;
                    break;
            }
        },
        removeInput(id) {
            this.chosen = this.chosen.filter(item => item.id != id);
            switch(id) {
                case 1:
                    this.whatsappIsChosen = false;
                    break;
                case 2:
                    this.facebookIsChosen = false;
                    break;
                case 3:
                    this.instagramIsChosen = false;
                    break;
                case 4:
                    this.telegramIsChosen = false;
                    break;
                case 5:
                    this.githubIsChosen = false;
                    break;
                case 6:
                    this.twitterIsChosen = false;
                    break;
            }
        },
        sendComponentDataToStore() {
            let whatsappLink = '';
            let facebookLink = '';
            let instagramLink = '';
            let telegramLink = '';
            let githubLink = '';
            let twitterLink = '';
            if(this.whatsappIsChosen) {
                let whatsapp = this.chosen.find(item => item.id == 1);
                whatsappLink = whatsapp.link;
            }
            if(this.facebookIsChosen) {
                let facebook = this.chosen.find(item => item.id == 2);
                facebookLink = facebook.link;
            }
            if(this.instagramIsChosen) {
                let instagram = this.chosen.find(item => item.id == 3);
                instagramLink = instagram.link;
            }
            if(this.telegramIsChosen) {
                let telegram = this.chosen.find(item => item.id == 4);
                telegramLink = telegram.link;
            }
            if(this.githubIsChosen) {
                let github = this.chosen.find(item => item.id == 5);
                githubLink = github.link;
            }
            if(this.twitterIsChosen) {
                let twitter = this.chosen.find(item => item.id == 6);
                twitterLink = twitter.link;
            }
            let obj = {
                website: this.website,
                whatsapp: whatsappLink,
                facebook: facebookLink,
                instagram: instagramLink,
                telegram: telegramLink,
                github: githubLink,
                twitter: twitterLink
            };
            console.log(obj);
            this.setCompanyComponent4Data(obj);
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
        ...mapGetters(['getCompanyComponent4Data']),
        getComponentData() {
            console.log(this.getCompanyComponent4Data);
            let website = this.getCompanyComponent4Data.website || '';
            let whatsappLink = this.getCompanyComponent4Data.whatsapp || '';
            let facebookLink = this.getCompanyComponent4Data.facebook;
            let instagramLink = this.getCompanyComponent4Data.instagram;
            let telegramLink = this.getCompanyComponent4Data.telegram;
            let githubLink = this.getCompanyComponent4Data.github;
            let twitterLink = this.getCompanyComponent4Data.twitter;
            if(website) {
                this.website = website;
            }
            if(whatsappLink) {
                let obj = {
                    id: 1,
                    name: 'whatsapp',
                    icon: '../../src/assets/icons/contacts/whatsapp.png',
                    link: whatsappLink
                };
                this.chosen.push(obj);
                this.whatsappIsChosen = true;
            }
            if(facebookLink) {
                let obj = {
                    id: 2,
                    name: 'facebook',
                    icon: '../../src/assets/icons/contacts/facebook.png',
                    link: facebookLink
                };
                this.chosen.push(obj);
                this.facebookIsChosen = true;
            }
            if(instagramLink) {
                let obj = {
                    id: 3,
                    name: 'instagram',
                    icon: '../../src/assets/icons/contacts/instagram.png',
                    link: instagramLink
                };
                this.chosen.push(obj);
                this.instagramIsChosen = true;
            }
            if(telegramLink) {
                let obj = {
                    id: 4,
                    name: 'telegram',
                    icon: '../../src/assets/icons/contacts/telegram.png',
                    link: telegramLink
                };
                this.chosen.push(obj);
                this.telegramIsChosen = true;
            }
            if(githubLink) {
                let obj = {
                    id: 5,
                    name: 'github',
                    icon: '../../src/assets/icons/contacts/github.png',
                    link: githubLink
                };
                this.chosen.push(obj);
                this.githubIsChosen = true;
            }
            if(twitterLink) {
                let obj = {
                    id: 6,
                    name: 'twitter',
                    icon: '../../src/assets/icons/contacts/twitter.png',
                    link: twitterLink
                };
                this.chosen.push(obj);
                this.twitterIsChosen = true;
            }
        }
    },
    mounted() {
        this.getComponentData;
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
    gap: 6px;
}
</style>
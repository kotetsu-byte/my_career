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
import {mapActions, mapGetters} from 'vuex';

export default {
    name: 'Component7',
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
        ...mapActions(['setComponent7Data', 'setUpdateResume']),
        choose(app) {
            let obj;
            switch(app) {
                case 'whatsapp':
                    obj = {
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
            if(this.getIsUpdate === false) {
                this.setComponent7Data(obj);
            } else {
                this.setUpdateResume(obj);
            }
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
        ...mapGetters(['getComponent7Data', 'getIsUpdate', 'getUpdateResume']),
        getComponentData() {
            let website;
            let whatsappLink;
            let facebookLink;
            let instagramLink;
            let telegramLink;
            let githubLink;
            let twitterLink;
            if(this.getIsUpdate === false) {
                website = this.getComponent7Data.website;
                whatsappLink = this.getComponent7Data.whatsapp;
                facebookLink = this.getComponent7Data.facebook;
                instagramLink = this.getComponent7Data.instagram;
                telegramLink = this.getComponent7Data.telegram;
                githubLink = this.getComponent7Data.github;
                twitterLink = this.getComponent7Data.twitter;
            } else {
                website = this.getUpdateResume.website;
                whatsappLink = this.getUpdateResume.whatsapp;
                facebookLink = this.getUpdateResume.facebook;
                instagramLink = this.getUpdateResume.instagram;
                telegramLink = this.getUpdateResume.telegram;
                githubLink = this.getUpdateResume.github;
                twitterLink = this.getUpdateResume.twitter;
            }
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
.container {
    margin: 100px auto 0 auto;
    min-width: 400px;
    max-width: max-content;
    background-color: white;
    border-radius: 12px;
    padding: 20px;
    width: max-content;
    max-width: 500px;
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
    gap: 6px;
}
</style>
<template>
    <div class="container">
        <div class="grid-div">
            <div>
                <p style="font-size: 25px; font-weight: 600;">{{ firstName }} {{ lastName }}</p>
                <p style="font-size: 15px; font-weight: 500;">{{ position }}</p>
                <div class="flex-div">
                    <div>
                        <p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/templates/frame 6/tel.png" alt="">{{ phoneNumber }}</p>
                    </div>
                    <div>
                        <p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/templates/frame 6/email.png" alt="">{{ email }}</p>
                    </div>
                </div>
                <p style="font-size: 10px; font-weight: 400;">
                    <img src="../../assets/icons/templates/frame 6/geo.png" alt="">{{ country }} {{ region }} {{ street }}
                </p>
            </div>
            <div>
                <img :src="photo" alt="" height="200" width="200">
            </div>
            <div>
                <div id="about">
                    <p style="background-color: #C7DAE0; font-size: 15px; font-weight: 500;">ABOUT ME</p>
                    <p style="font-size: 12px; font-weight: 400;">{{ selfDescription }}</p>
                </div>
                <div id="language">
                    <p style="background-color: #C7DAE0; font-size: 15px; font-weight: 500;">LANGUAGE</p>
                    <div v-for="(item, index) in languages" :key="index">
                        <p style="font-size: 12px; font-weight: 400;">{{ item.lang }} - {{ item.level }}</p>
                    </div>
                    <p style="font-size: 12px; font-weight: 400;">FRENCH</p>
                    <p style="font-size: 12px; font-weight: 400;">GERMAN</p>
                </div>
                <div id="skills">
                    <p style="background-color: #C7DAE0; font-size: 15px; font-weight: 500;">SKILLS</p>
                    <p style="font-size: 12px; font-weight: 400;">{{ skills }}</p>
                    <p style="font-size: 12px; font-weight: 400;">FIGMA</p>
                    <p style="font-size: 12px; font-weight: 400;">ADOBE XD</p>
                </div>
                <div id="hobbies">
                    <p style="background-color: #C7DAE0; font-size: 15px; font-weight: 500;">HOBBIES</p>
                    <p style="font-size: 12px; font-weight: 400;">{{ hobbies }}</p>
                    <p style="font-size: 12px; font-weight: 400;">FIGMA</p>
                    <p style="font-size: 12px; font-weight: 400;">ADOBE XD</p>
                </div>
            </div>
            <div>
                <div id="education">
                    <p style="background-color: #C7DAE0; font-size: 15px; font-weight: 500;">EDUCATION</p>
                    <div v-for="(item, index) in education" :key="index">
                        <p style="font-size: 12px; font-weight: 400;">{{ item.degree }} ({{ item.from }}-{{ item.to }})</p>
                        <p style="font-size: 12px; font-weight: 400;">{{ item.schoolName }}</p>
                        <p style="font-size: 12px; font-weight: 400;">{{ item.typeOfStudy }}</p>
                        <p style="font-size: 12px; font-weight: 400;">{{ item.location }}</p>    
                    </div>
                    <p style="font-size: 12px; font-weight: 400;">Name Of Degree (2021-2022)</p>
                    <p style="font-size: 12px; font-weight: 400;">Name Of university</p>
                    <p style="font-size: 12px; font-weight: 400;">Everything is a bit different nowadays. The word "art" has a special meaning. It means something beautiful.</p>
                </div>
                <div id="experience">
                    <p style="background-color: #C7DAE0; font-size: 15px; font-weight: 500;">EXPERIENCE</p>
                    <div v-for="(item, index) in experience" :key="index">
                        <p style="font-size: 12px; font-weight: 400;">{{ item.job }} ({{ item.from }}-{{ item.to }})</p>
                        <p style="font-size: 12px; font-weight: 400;">{{ item.companyName }}</p>
                        <p style="font-size: 12px; font-weight: 400;">{{ item.description }}</p>
                    </div>
                </div>
                <div id="contacts">
                    <p style="background-color: #C7DAE0; font-size: 15px; font-weight: 500;">CONTACTS</p>
                    <div v-if="website"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/website.png" alt="">{{ website }}</p></div>
                    <div v-if="whatsapp"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/whatsapp.png" alt="">{{ whatsapp }}</p></div>
                    <div v-if="facebook"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/facebook.png" alt="">{{ facebook }}</p></div>
                    <div v-if="instagram"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/instagram.png" alt="">{{ instagram }}</p></div>
                    <div v-if="telegram"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/telegram.png" alt="">{{ telegram }}</p></div>
                    <div v-if="github"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/github.png" alt="">{{ github }}</p></div>
                    <div v-if="twitter"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/twitter.png" alt="">{{ twitter }}</p></div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'Frame6',
    components: {},
    data() {
        return {
        }
    },
    props: {
        photo: FileReader,
        firstName: String,
        lastName: String,
        email: String,
        phoneNumber: String,
        country: String,
        region: String,
        street: String,
        position: String,
        dateOfBirth: Date,
        skills: String,
        hobbies: String,
        selfDescription: String,
        languages: Array,
        experience: Array,
        education: Array,
        website: String,
        whatsapp: String,
        facebook: String,
        instagram: String,
        telegram: String,
        github: String,
        twitter: String
    },
}
</script>

<style scoped>
.container {
    width: 600px;
    height: max-content;
    border-radius: 12px;
}
.flex-div {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-self: center;
}
.grid-div {
    display: grid;
    grid-template-columns: 1fr 1fr;
}
</style>
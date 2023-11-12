<template>
    <div class="container">
        <div class="flex-div">
            <div style="width: 39%; background-color: #212026; color: white;">
                <img :src="photo" style="width: 100%;" alt="" height="200" width="200">
                <p style="background-color: #323136; font-size: 12px; font-weight: 500;">Phone</p>
                <p style="font-size: 10px; font-weight: 400;">{{ phoneNumber }}</p>
                <img src="../../assets/icons/templates/frame 3/email.png" alt="">
                <p style="background-color: #323136; font-size: 12px; font-weight: 500;">E-mail</p>
                <p style="font-size: 10px; font-weight: 400;">{{ email }}</p>
                <img src="../../assets/icons/templates/frame 3/website.png" alt="">
                <p style="background-color: #323136; font-size: 12px; font-weight: 500;">Website</p>
                <p style="font-size: 10px; font-weight: 400;">www.user.com</p>
                <img src="../../assets/icons/templates/frame 3/geo.png" alt="">
                <p style="background-color: #323136; font-size: 12px; font-weight: 500;">Address</p>
                <p style="font-size: 10px; font-weight: 400;">{{ country }} {{ region }} {{ street }}</p>
                <div id="skills">
                    <p style="font-size: 15px; font-weight: 500;">SKILLS</p>
                    <hr>
                    <p style="font-size: 10px; font-weight: 400;">{{ skills }}</p>
                    <p style="font-size: 10px; font-weight: 400;">Figma</p>
                    <p style="font-size: 10px; font-weight: 400;">Adobe xD</p>
                </div>
                <div id="languages">
                    <p style="font-size: 15px; font-weight: 500;">LANGUAGES</p>
                    <hr>
                    <div v-for="(item, index) in languages" :key="index">
                        <p style="font-size: 10px; font-weight: 400;">{{ item.lang }} - {{ item.level }}</p>
                    </div>
                    <p style="font-size: 10px; font-weight: 400;">French - level</p>
                    <p style="font-size: 10px; font-weight: 400;">Korean - level</p>
                    <p style="font-size: 10px; font-weight: 400;">Uzbek - level</p>
                </div>
                <div id="hobbies">
                    <p style="font-size: 15px; font-weight: 500;">HOBBIES</p>
                    <hr>
                    <p style="font-size: 10px; font-weight: 400;">{{ hobbies }}</p>
                    <p style="font-size: 10px; font-weight: 400;">Languages</p>
                    <p style="font-size: 10px; font-weight: 400;">Books</p>
                    <p style="font-size: 10px; font-weight: 400;">IT</p>
                </div>
                <div id="contacts">
                    <p style="font-size: 15px; font-weight: 500;">CONTACTS</p>
                    <hr>
                    <div v-if="website"><p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/contacts/website.png" alt="">{{ website }}</p></div>
                    <div v-if="whatsapp"><p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/contacts/whatsapp.png" alt="">{{ whatsapp }}</p></div>
                    <div v-if="facebook"><p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/contacts/facebook.png" alt="">{{ facebook }}</p></div>
                    <div v-if="instagram"><p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/contacts/instagram.png" alt="">{{ instagram }}</p></div>
                    <div v-if="telegram"><p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/contacts/telegram.png" alt="">{{ telegram }}</p></div>
                    <div v-if="github"><p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/contacts/github.png" alt="">{{ github }}</p></div>
                    <div v-if="twitter"><p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/contacts/twitter.png" alt="">{{ twitter }}</p></div>
                </div>
            </div>
            <div style="width: 59%;">
                <div style="background-color: #FECB00;">
                    <p style="font-size: 25px; font-weight: 500;"><span style="font-weight: 800;">{{ firstName }}</span> {{ lastName }}</p>
                    <p style="font-size: 12px; font-weight: 400;">{{ dateOfBirth }}</p>
                    <p style="font-size: 12px; font-weight: 400;">{{ position }}</p>
                </div>
                <div id="about">
                    <p style="font-size: 15px; font-weight: 500;">ABOUT ME</p>
                    <hr>
                    <p style="font-size: 10px; font-weight: 400;">{{ selfDescription }}</p>
                </div>
                <div id="education">
                    <p style="font-size: 15px; font-weight: 500;">EDUCATION</p>
                    <hr>
                    <div v-for="(item, index) in education" :key="index">
                        <div class="flex-div" style="justify-content: start;">
                            <div>
                                <p style="font-style: 10px; font-weight: 600;">{{ item.from }} - {{ item.to }}</p>
                            </div>
                            <div>
                                <p style="font-size: 10px; font-weight: 600;">{{ item.schoolName }}</p>
                                <p style="font-size: 10px; font-weight: 400;">{{ item.degree }}</p>
                                <p style="font-size: 10px; font-weight: 400;">{{ item.typeOfStudy }}</p>
                                <p style="font-size: 10px; font-weight: 400;">{{ item.location }}</p>
                            </div>
                        </div>
                    </div>
                    <div class="flex-div" style="justify-content: start;">
                        <div>
                            <p style="font-style: 10px; font-weight: 600;">2012 - 2014</p>
                        </div>
                        <div>
                            <p style="font-size: 10px; font-weight: 600;">ENTER UNI</p>
                            <p style="font-size: 10px; font-weight: 400;">Degree</p>
                            <p style="font-size: 10px; font-weight: 400;">Type of study</p>
                            <p style="font-size: 10px; font-weight: 400;">Location</p>
                        </div>
                    </div>
                    <div class="flex-div" style="justify-content: start;">
                        <div>
                            <p style="font-style: 10px; font-weight: 600;">2012 - 2014</p>
                        </div>
                        <div>
                            <p style="font-size: 10px; font-weight: 600;">ENTER UNI</p>
                            <p style="font-size: 10px; font-weight: 400;">Degree</p>
                            <p style="font-size: 10px; font-weight: 400;">Type of study</p>
                            <p style="font-size: 10px; font-weight: 400;">Location</p>
                        </div>
                    </div>
                </div>
                <div id="experience">
                    <p style="font-size: 15px; font-weight: 500;">EXPERIENCE</p>
                    <hr>
                    <div v-for="(item, index) in experience" :key="index">
                        <div class="flex-div" style="justify-content: start; width: max-content;">
                            <div>
                                <p style="font-style: 10px; font-weight: 600;">{{ item.from }} - {{ item.to }}</p>
                            </div>
                            <div>
                                <p style="font-size: 10px; font-weight: 600;">{{ item.job }}</p>
                                <p style="font-size: 10px; font-weight: 400;">{{ item.companyName }}</p>
                                <p style="font-size: 10px; font-weight: 400;">{{ item.description }}</p>
                            </div>
                        </div>
                    </div>
                    <div class="flex-div" style="justify-content: start; width: max-content;">
                        <div>
                            <p style="font-style: 10px; font-weight: 600;">2012 - 2014</p>
                        </div>
                        <div>
                            <p style="font-size: 10px; font-weight: 600;">Senior UX Designer</p>
                            <p style="font-size: 10px; font-weight: 400;">Name of company</p>
                            <p style="font-size: 10px; font-weight: 400;">Everything is a bit different nowadays. The word "art" has a<br> special meaning. It means something beautiful.</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'Frame3',
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
</style>
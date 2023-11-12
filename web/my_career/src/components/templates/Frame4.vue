<template>
    <div class="container">
        <div class="flex-div">
            <div style="width: 39%; background-color: #776CE2; color: white;">
                <img :src="photo" alt="" height="200" width="200"><br>
                <img src="../../assets/icons/templates/frame 4/tel.png" alt="">
                <p style="font-size: 12px; font-weight: 400;">{{ phoneNumber }}</p>
                <img src="../../assets/icons/templates/frame 4/email.png" alt="">
                <p style="font-size: 12px; font-weight: 400;">{{ email }}</p>
                <img src="../../assets/icons/templates/frame 4/geo.png" alt="">
                <p style="font-size: 12px; font-weight: 400;">{{ country }} {{ region }} {{ street }}</p>
                <div id="skills">
                    <p style="background-color: white; color: #776CE2; font-size: 15px; font-weight: 800;">SKILLS</p>
                    <hr>
                    <p style="font-size: 10px; font-weight: 400;">{{ skills }}</p>
                    <p style="font-size: 10px; font-weight: 400;">Figma</p>
                    <p style="font-size: 10px; font-weight: 400;">Adobe xD</p>
                </div>
                <div id="languages">
                    <p style="background-color: white; color: #776CE2; font-size: 15px; font-weight: 800;">LANGUAGES</p>
                    <hr>
                    <div v-for="(item, index) in languages" :key="index">
                        <p style="font-size: 10px; font-weight: 400;">{{ item.lang }} - {{ item.level }}</p>
                    </div>
                    <p style="font-size: 10px; font-weight: 400;">French - level</p>
                    <p style="font-size: 10px; font-weight: 400;">Korean - level</p>
                    <p style="font-size: 10px; font-weight: 400;">Uzbek - level</p>
                </div>
                <div id="hobbies">
                    <p style="background-color: white; color: #776CE2; font-size: 15px; font-weight: 800;">HOBBIES</p>
                    <hr>
                    <p style="font-size: 10px; font-weight: 400;">{{ hobbies }}</p>
                    <p style="font-size: 10px; font-weight: 400;">Languages</p>
                    <p style="font-size: 10px; font-weight: 400;">Books</p>
                    <p style="font-size: 10px; font-weight: 400;">IT</p>
                </div>
                <div id="contacts">
                    <p style="background-color: white; color: #776CE2; font-size: 15px; font-weight: 800;">CONTACTS</p>
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
                <div>
                    <p style="font-size: 35px; font-weight: 500;">{{ firstName }} <span style="font-weight: 800;">{{ lastName }}</span></p>
                    <p style="font-size: 10px; font-weight: 500;">{{ position }}</p>
                </div>
                <div id="about">
                    <p style="font-size: 15px; font-weight: 500; color: #776CE2;">ABOUT ME</p>
                    <p style="font-size: 10px; font-weight: 400;">{{ selfDescription }}</p>
                </div>
                <div id="education">
                    <p style="font-size: 15px; font-weight: 800; color: white; background-color: #776CE2;">EDUCATION</p>
                    <div v-for="(item, index) in education" :key="index">
                        <div class="flex-div">
                            <div>
                                <p style="font-size: 12px; font-weight: 500;">ED-N</p>
                            </div>
                            <div>
                                <p style="font-size: 9px; font-weight: 500; color: #776CE2;">{{ item.from }} - {{ item.to }}</p>
                            </div>
                        </div>
                        <p style="font-size: 10px; font-weight: 400;">{{ item.schoolName }}</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ item.degree }}</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ item.typeOfStudy }}</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ item.location }}</p>
                    </div>
                </div>
                <div id="experience">
                    <p style="font-size: 15px; font-weight: 800; color: white; background-color: #776CE2;">EXPERIENCE</p>
                    <div v-for="(item, index) in experience" :key="index">
                        <div class="flex-div">
                            <div>
                                <p style="font-size: 12px; font-weight: 500;">ED-N</p>
                            </div>
                            <div>
                                <p style="font-size: 9px; font-weight: 500; color: #776CE2;">{{ item.from }} - {{ item.to }}</p>
                            </div>
                        </div>
                        <p style="font-size: 10px; font-weight: 400;">{{ item.companyName }}</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ item.job }}</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ item.description }}</p>
                    </div>
                    <div class="flex-div">
                        <div>
                            <p style="font-size: 12px; font-weight: 500;">ED-N</p>
                        </div>
                        <div>
                            <p style="font-size: 9px; font-weight: 500; color: #776CE2;">Avg 18-July 19</p>
                        </div>
                    </div>
                    <p style="font-size: 10px; font-weight: 400;">Name of Company</p>
                    <p style="font-size: 10px; font-weight: 400;">Everything is a bit different nowadays. The word "art" has a special meaning. It means something beautiful.</p>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'Frame4',
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
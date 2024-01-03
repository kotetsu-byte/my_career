<template>
    <div class="container">
        <header>
            <div class="flex-div">
                <div style="width: 39%;">
                    <img :src="photo" alt="" height="200" width="200">
                </div>
                <div style="width: 59%;">
                    <p id="full-name" style="font-size: 32px; font-weight: 700;">{{ firstName }} {{ lastName }}</p>
                    <p id="date-of-birth" style="font-size: 15px; font-weight: 400;">{{ dateOfBirth }}</p>
                    <p id="position" style="font-size: 15px; font-weight: 400;">{{ position }}</p>
                    <br><br>
                    <img src="../../assets/icons/templates/frame 1/tel.png" alt="">
                    <span style="font-size: 12px; font-weight: 400;">{{ phoneNumber }}</span><br>
                    <img src="../../assets/icons/templates/frame 1/email.png" alt="">
                    <span style="font-size: 12px; font-weight: 400;">{{ email }}</span><br>
                    <img src="../../assets/icons/templates/frame 1/geo.png" alt="">
                    <span style="font-size: 12px; font-weight: 400;">{{ country}} {{ region}} {{ street}}</span>
                </div>
            </div>
        </header>
        <hr style="margin: 0 10px;">
        <main>
            <div class="flex-div" style="align-items: start;">
                <div style="width: 39%;" id="for-hr">
                    <div id="skills">
                        <p style="font-size: 22px; font-weight: 700;">Skills</p>
                        <p style="font-size: 12px; font-weight: 400;">{{ skills }}</p>
                    </div>
                    <div id="languages">
                        <p style="font-size: 22px; font-weight: 700;">Languages</p>
                        <div v-for="(item, index) in languages" :key="index">
                            <p style="font-size: 12px; font-weight: 400;">{{ item.lang }} - {{ item.level }}</p>
                        </div>
                    </div>
                    <div id="hobbies">
                        <p style="font-size: 22px; font-weight: 700;">Hobbies</p>
                        <ul>
                            <li style="font-size: 12px; font-weight: 400;">{{ hobbies }}</li>
                        </ul>
                    </div>
                    <div id="contacts">
                        <p style="font-size: 22px; font-weight: 700;">Contacts</p>
                        <div v-if="website"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/website.png" alt="">{{ webiste }}</p></div>
                        <div v-if="whatsapp"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets//icons/contacts/whatsapp.png" alt="">{{ whatsapp }}</p></div>
                        <div v-if="facebook"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/facebook.png" alt="">{{ facebook }}</p></div>
                        <div v-if="instagram"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/instagram.png" alt="">{{ instagram }}</p></div>
                        <div v-if="telegram"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/telegram.png" alt="">{{ telegram }}</p></div>
                        <div v-if="github"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/github.png" alt="">{{ github }}</p></div>
                        <div v-if="twitter"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/twitter.png" alt="">{{ twitter }}</p></div>
                    </div>
                </div>
                <hr id="vertical-hr">
                <div style="width: 59%;">
                    <div id="about">
                        <p style="font-size: 22px; font-weight: 700;">About me</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ aboutSelf }}</p>
                    </div>
                    <div id="education">
                        <p style="font-size: 22px; font-weight: 700;">Education</p>
                        <div v-for="(item, index) in education" :key="index">
                            <div class="flex-div" style="align-items: start;">
                                <div style="width: 40%;">
                                    <p style="font-size: 12px; font-weight: 400;">{{ item.from }} - {{ item.to }}</p>
                                    <p style="font-size: 12px; font-weight: 400;">{{ item.schoolName }}</p>
                                </div>
                                <div>
                                    <p style="font-size: 10px; font-weight: 500;">{{ item.degree }}</p>
                                    <p style="font-size: 10px; font-weight: 500;">{{ item.typeOfStudy }}</p>
                                    <p style="font-size: 10px; font-weight: 400;">{{ item.location }}</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div id="experience">
                        <p style="font-size: 22px; font-weight: 700;">Experience</p>
                        <div v-for="(item, index) in experience" :key="index">
                            <div class="flex-div" style="align-items: start;">
                                <div style="width: 40%;">
                                    <p style="font-size: 12px; font-weight: 400;">{{ item.from }} - {{ item.to }}</p>
                                    <p style="font-size: 12px; font-weight: 400;">{{ item.companyName }}</p>
                                </div>
                                <div>
                                    <p style="font-size: 10px; font-weight: 500;">{{ item.job }}</p>
                                    <p style="font-size: 10px; font-weight: 500;">{{ item.description }}</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </main>
    </div>
</template>

<script>
export default {
    name: 'Frame1',
    components: {},
    data() {
        return {
            isCustom: false
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
        aboutSelf: String,
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
    methods: {
        setVerticalHrWith() {
            let height = document.getElementById("for-hr").offsetHeight;
            document.getElementById("vertical-hr").style.height = height + 'px';
        }
    },
    watch: {
    },
    computed: {
        
    },
    mounted() {
        this.setVerticalHrWith();
    }
}
</script>

<style scoped>
.container {
    width: 600px;
    height: max-content;
    border-radius: 12px;
}

header {
    padding: 10px 40px;
}

main {
    padding: 10px 40px;
}

.vertical {
    height: max-content;
    height: 100vh;
    margin: 0;
}

#skills, #languages, #hobbies, #contacts {
    padding: 10px 0;
}
.flex-div {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
}
</style>
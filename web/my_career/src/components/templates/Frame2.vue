<template>
    <div class="container">
        <div id="header" style="background-color: #171B26;">
            <div class="flex-div" style="justify-content: start;">
                <div style="width: 39%;">
                    <div style="height: 100%; background-color: #747474;">
                        <img :src="photo" alt="" style="width: 100%;" height="200" width="200">
                    </div>
                </div>
                <div style="width: 59%; padding-left: 30px;">
                    <p id="full-name" style="font-size: 35px; font-weight: 700; color: white; margin: 10px 0;">{{ firstName }} {{ lastName }}</p>
                    <p style="font-size: 20px; font-weight: 500; color: white; margin: 10px 0;">{{ dateOfBirth }}</p>
                    <p id="position" style="background-color: #42454E; width: max-content; padding: 1px 5px; color: white; font-size: 20px; font-weight: 700;">{{ position }}</p>
                    <br><br>
                    <div class="flex-div" style="justify-content: start;">
                        <div style="margin: 10px 0;">
                            <p style="color: white; font-size: 12px; font-weight: 500;">Phone:</p>
                            <p style="color: #E5E5E5; font-size: 10px; font-weight: 300;">{{ phoneNumber }}</p>
                        </div>
                        <div style="margin: 10px 0; margin-left: 10px;">
                            <p style="color: white; font-size: 12px; font-weight: 500;">E-mail:</p>
                            <p style="color: #E5E5E5; font-size: 10px; font-weight: 300;">{{ email }}</p>
                        </div>
                    </div>
                    <p style="color: white; font-size: 12px; font-weight: 500;">Address:</p>
                    <p style="color: #E5E5E5; font-size: 10px; font-weight: 300;">{{ country }} {{ region }} {{ street }}</p>
                </div>
            </div>
        </div>
        <div id="main">
            <div class="flex-div" style="align-items: start;">
                <div style="background-color: #747474; width: 39%;">
                    <div id="skills">
                        <p style="font-size: 20px; font-weight: 700;">Skills</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ skills }}</p>
                    </div>
                    <div id="languages">
                        <p style="font-size: 20px; font-weight: 700;">Languages</p>
                        <div v-for="(item, index) in languages" :key="index">
                            <p style="font-size: 10px; font-weight: 400;">{{ item.lang }} - {{ item.level }}</p>
                        </div>
                    </div>
                    <div id="hobbies">
                        <p style="font-size: 20px; font-weight: 700;">Hobbies</p>
                        <ul style="padding-left: 20px;">
                            <li style="font-size: 11px; font-weight: 500;">{{ hobbies }}</li>
                        </ul>
                    </div>
                    <div id="contacts">
                        <p style="font-size: 20px; font-weight: 700;">Contacts</p>
                        <div v-if="website"><p style="font-size: 10px; font-weight: 500;"><img src="../../assets/icons/contacts/website.png" alt="">{{ website }}</p></div>
                        <div v-if="whatsapp"><p style="font-size: 10px; font-weight: 500;"><img src="../../assets/icons/contacts/whatsapp.png" alt="">{{ whatsapp }}</p></div>
                        <div v-if="facebook"><p style="font-size: 10px; font-weight: 500;"><img src="../../assets/icons/contacts/facebook.png" alt="">{{ facebook }}</p></div>
                        <div v-if="instagram"><p style="font-size: 10px; font-weight: 500;"><img src="../../assets/icons/contacts/instagram.png" alt="">{{ instagram }}</p></div>
                        <div v-if="telegram"><p style="font-size: 10px; font-weight: 500;"><img src="../../assets/icons/contacts/telegram.png" alt="">{{ telegram }}</p></div>
                        <div v-if="github"><p style="font-size: 10px; font-weight: 500;"><img src="../../assets/icons/contacts/github.png" alt="">{{ github }}</p></div>
                        <div v-if="twitter"><p style="font-size: 10px; font-weight: 500;"><img src="../../assets/icons/contacts/twitter.png" alt="">{{ twitter }}</p></div>
                    </div>
                </div>
                <div style="width: 59%;">
                    <div id="about">
                        <p style="font-size: 20px; font-weight: 700;">About me</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ aboutSelf }}</p>
                    </div>
                    <div id="education">
                        <p style="font-size: 20px; font-weight: 700;">Education</p>
                        <div v-for="(item, index) in education" :key="index">
                            <div class="flex-div" style="justify-content: start;">
                                <div>
                                    <p style="font-size: 10px; font-weight: 400;">{{ item.from }} - {{ item.to }}</p>
                                    <p style="font-size: 10px; font-weight: 400;">{{ item.schoolName }}</p>
                                </div>
                                <div style="margin-left: 10px;">
                                    <p style="font-size: 10px; font-weight: 500;">{{ item.degree }}</p>
                                    <p style="font-size: 10px; font-weight: 500;">{{ item.typeOfStudy }}</p>
                                    <p style="font-size: 10px; font-weight: 400;">{{ item.location }}</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div id="experience">
                        <p style="font-size: 20px; font-weight: 700;">Experience</p>
                        <div v-for="(item, index) in experience" :key="index">
                            <div class="flex-div" style="justify-content: start;">
                                <div>
                                    <p style="font-size: 10px; font-weight: 400;">{{ item.from }} - {{ item.to }}</p>
                                    <p style="font-size: 10px; font-weight: 400;">{{ item.companyName }}</p>
                                </div>
                                <div>
                                    <p style="font-size: 10px; font-weight: 500;">{{ item.job }}</p>
                                    <p style="font-size: 10px; font-weight: 400;">{{ item.description }}</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'Frame2',
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
}
</script>

<style scoped>
.container {
    width: 600px;
    height: max-content;
    border-radius: 12px;
}

#header {
    padding: 40px;
    width: 100%;
}

#main {
    padding: 40px;
    width: 100%;
}

#skills, #languages, #hobbies, #contacts {
    padding: 10px 0;
}
.flex-div {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-self: center;
}
</style>
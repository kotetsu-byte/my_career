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
                    <p id="full-name" style="font-size: 35px; font-weight: 700; color: white; margin: 10px 0;">{{ companyName }}</p>
                    <br><br>
                    <div class="flex-div" style="justify-content: start;">
                        <div style="margin: 10px 0;">
                            <p style="color: white; font-size: 12px; font-weight: 500;">Phone:</p>
                            <p style="color: #E5E5E5; font-size: 10px; font-weight: 300;">{{ companyPhoneNumber }}</p>
                        </div>
                    </div>
                    <p style="color: white; font-size: 12px; font-weight: 500;">Address:</p>
                    <p style="color: #E5E5E5; font-size: 10px; font-weight: 300;">{{ address }}</p>
                </div>
            </div>
        </div>
        <div id="main">
            <div class="flex-div" style="align-items: start;">
                <div style="background-color: #747474; width: 39%;">
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
                        <p style="font-size: 10px; font-weight: 400;">{{ description }}</p>
                    </div>
                    <div>
                        <p style="font-size: 22px; font-weight: 700;">About me</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ firstName }} {{ lastName }}</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ email }}</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ phoneNumber }}</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'CompanyFrame2',
    components: {},
    data() {
        return {
        }
    },
    props: {
        photo: FileReader,
        companyName: String,
        companyPhoneNumber: String,
        address: String,
        website: String,
        whatsapp: String,
        facebook: String,
        instagram: String,
        telegram: String,
        github: String,
        twitter: String,
        description: String,
        firstName: String,
        lastName: String,
        email: String,
        phoneNumber: String,
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
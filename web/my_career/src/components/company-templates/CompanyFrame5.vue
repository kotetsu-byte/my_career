<template>
    <div class="container">
        <div class="grid-div">
            <div style="width: 95%;">
                <p style="font-size: 30px; font-weight: 700; color: #FFC905">{{ companyName }}</p>
                <div class="flex-div">
                    <div>
                        <p style="font-size: 11px; font-weight: 500;">Phone:</p>
                        <p style="font-size: 10px; font-weight: 300;">{{ companyPhoneNumber }}</p>
                    </div>
                    <div>
                        <p style="font-size: 11px; font-weight: 500;">Address:</p>
                        <p style="font-size: 10px; font-weight: 300;">{{ address }}</p>
                    </div>
                </div>
            </div>
            <div style="background-color: #FFC905; width: 39%;">
                <img :src="photo" alt="" height="200" width="200">
            </div>
            <div style="background-color: #2B3036; width: 95%; color: white;">
                <div id="cotacts">
                    <p style="font-size: 20px; font-weight: 400;">CONTACTS</p>
                    <div v-if="website"><p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/contacts/website.png" alt="">{{ website }}</p></div>
                    <div v-if="whatsapp"><p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/contacts/whatsapp.png" alt="">{{ whatsapp }}</p></div>
                    <div v-if="facebook"><p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/contacts/facebook.png" alt="">{{ facebook }}</p></div>
                    <div v-if="instagram"><p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/contacts/instagram.png" alt="">{{ instagram }}</p></div>
                    <div v-if="telegram"><p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/contacts/telegram.png" alt="">{{ telegram }}</p></div>
                    <div v-if="github"><p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/contacts/github.png" alt="">{{ github }}</p></div>
                    <div v-if="twitter"><p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/contacts/twitter.png" alt="">{{ twitter }}</p></div>
                </div>
            </div>
            <div style="width: 39%;">
                <div id="about">
                    <p style="font-size: 20px; font-weight: 400;">ABOUT ME</p>
                    <p style="font-size: 10px; font-weight: 400;">{{ selfDescription }}</p>
                </div>
                <div>
                    <p style="font-size: 20px; font-weight: 400;">About me</p>
                    <p style="font-size: 10px; font-weight: 400;">{{ firstName }} {{ lastName }}</p>
                    <p style="font-size: 10px; font-weight: 400;">{{ email }}</p>
                    <p style="font-size: 10px; font-weight: 400;">{{ phoneNumber }}</p>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'CompanyFrame5',
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
.flex-div {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-self: center;
}
.grid-div {
    display: grid;
    grid-template-columns: 59% 39%;
}
</style>
<template>
    <div class="container">
        <div class="grid-div">
            <div>
                <p style="font-size: 25px; font-weight: 600;">{{ companyName }}</p>
                <div class="flex-div">
                    <div>
                        <p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/templates/frame 6/tel.png" alt="">{{ companyPhoneNumber }}</p>
                    </div>
                    <div>
                        <p style="font-size: 10px; font-weight: 400;">
                            <img src="../../assets/icons/templates/frame 6/geo.png" alt="">{{ address }}
                        </p>
                    </div>
                </div>
            </div>
            <div>
                <img :src="photo" alt="" height="200" width="200">
            </div>
            <div>
                <div id="about">
                    <p style="background-color: #C7DAE0; font-size: 15px; font-weight: 500;">ABOUT ME</p>
                    <p style="font-size: 12px; font-weight: 400;">{{ selfDescription }}</p>
                </div>
                <div>
                    <p style="background-color: #C7DAE0; font-size: 15px; font-weight: 500;">About me</p>
                    <p style="font-size: 12px; font-weight: 400;">{{ firstName }} {{ lastName }}</p>
                    <p style="font-size: 12px; font-weight: 400;">{{ email }}</p>
                    <p style="font-size: 12px; font-weight: 400;">{{ phoneNumber }}</p>
                </div>
            </div>
            <div>
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
    name: 'CompanyFrame6',
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
    grid-template-columns: 1fr 1fr;
}
</style>
<template>
    <div class="container">
        <header>
            <div class="flex-div">
                <div style="width: 39%;">
                    <img :src="photo" alt="" height="200" width="200">
                </div>
                <div style="width: 59%;">
                    <p id="full-name" style="font-size: 32px; font-weight: 700;">{{ companyName }}</p>
                    <br><br>
                    <img src="../../assets/icons/templates/frame 1/tel.png" alt="" />
                    <span style="font-size: 12px; font-weight: 400;">{{ companyPhoneNumber }}</span><br>
                    <img src="../../assets/icons/templates/frame 1/geo.png" alt="">
                    <span style="font-size: 12px; font-weight: 400;">{{ address }}</span>
                </div>
            </div>
        </header>
        <hr style="margin: 0 10px;">
        <main>
            <div class="flex-div" style="align-items: start;">
                <div style="width: 39%;" id="for-hr">
                    <div id="contacts">
                        <p style="font-size: 22px; font-weight: 700;">Contacts</p>
                        <div v-if="website"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/website.png" alt="">{{ website }}</p></div>
                        <div v-if="whatsapp"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/whatsapp.png" alt="">{{ whatsapp }}</p></div>
                        <div v-if="facebook"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/facebook.png" alt="">{{ facebook }}</p></div>
                        <div v-if="instagram"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/instagram.png" alt="">{{ instagram }}</p></div>
                        <div v-if="telegram"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/telegram.png" alt="">{{ telegram }}</p></div>
                        <div v-if="github"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/github.png" alt="">{{ github }}</p></div>
                        <div v-if="twitter"><p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/contacts/twitter.png" alt="">{{ twitter }}</p></div>
                    </div>
                </div>
                <hr id="vertical-hr">
                <div style="width: 59%;">
                    <div>
                        <p style="font-size: 22px; font-weight: 700;">About company</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ description }}</p>
                    </div>
                    <div id="about">
                        <p style="font-size: 22px; font-weight: 700;">About me</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ firstName }} {{ lastName }}</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ email }}</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ phoneNumber }}</p>
                    </div>
                </div>
            </div>
        </main>
    </div>
</template>

<script>
export default {
    name: 'CompanyFrame1',
    components: {},
    data() {
        return {
            isCustom: false
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
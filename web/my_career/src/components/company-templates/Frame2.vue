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
                        <p><img src="../../assets/icons/templates/frame 1/whatsapp" alt=""><span style="font-size: 10px; font-weight: 500;">{{ contacts }}</span></p>
                        <p><img src="../../assets/icons/templates/frame 1/facebook" alt=""><span style="font-size: 10px; font-weight: 500;">Murphy_design_2001</span></p>
                        <p><img src="../../assets/icons/templates/frame 1/instagram" alt=""><span style="font-size: 10px; font-weight: 500;">Murphy_design_2001</span></p>
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
    name: 'Frame2',
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
        contacts: String,
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
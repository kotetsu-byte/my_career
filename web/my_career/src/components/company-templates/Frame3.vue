<template>
    <div class="container">
        <div class="flex-div">
            <div style="width: 39%; background-color: #212026; color: white;">
                <img :src="photo" style="width: 100%;" alt="" height="200" width="200">
                <p style="background-color: #323136; font-size: 12px; font-weight: 500;">Phone</p>
                <p style="font-size: 10px; font-weight: 400;">{{ companyPhoneNumber }}</p>
                <img src="../../assets/icons/templates/frame 3/website.png" alt="">
                <p style="background-color: #323136; font-size: 12px; font-weight: 500;">Website</p>
                <p style="font-size: 10px; font-weight: 400;">www.user.com</p>
                <img src="../../assets/icons/templates/frame 3/geo.png" alt="">
                <p style="background-color: #323136; font-size: 12px; font-weight: 500;">Address</p>
                <p style="font-size: 10px; font-weight: 400;">{{ address }}</p>
                <div id="contacts">
                    <p style="font-size: 15px; font-weight: 500;">CONTACTS</p>
                    <hr>
                    <p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/templates/frame 3/whatsapp" alt="">{{ contacts }}</p>
                    <p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/templates/frame 3/facebook" alt="">Murphy_design_2001</p>
                    <p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/templates/frame 3/instagram" alt="">Murphy_design_2001</p>
                </div>
            </div>
            <div style="width: 59%;">
                <div style="background-color: #FECB00;">
                    <p style="font-size: 25px; font-weight: 500;"><span style="font-weight: 800;">{{ firstName }}</span> {{ lastName }}</p>
                </div>
                <div id="about">
                    <p style="font-size: 15px; font-weight: 500;">ABOUT ME</p>
                    <hr>
                    <p style="font-size: 10px; font-weight: 400;">{{ description }}</p>
                </div>
                <div>
                    <p style="font-size: 15px; font-weight: 500;">About me</p>
                    <hr>
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
    name: 'Frame3',
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
.flex-div {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-self: center;
}
</style>
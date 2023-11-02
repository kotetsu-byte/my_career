<template>
    <div class="container">
        <div class="flex-div">
            <div style="width: 39%; background-color: #776CE2; color: white;">
                <img :src="photo" alt="" height="200" width="200"><br>
                <img src="../../assets/icons/templates/frame 4/tel.png" alt="">
                <p style="font-size: 12px; font-weight: 400;">{{ companyPhoneNumber }}</p>
                <img src="../../assets/icons/templates/frame 4/geo.png" alt="">
                <p style="font-size: 12px; font-weight: 400;">{{ address }}</p>
                <div id="contacts">
                    <p style="background-color: white; color: #776CE2; font-size: 15px; font-weight: 800;">CONTACTS</p>
                    <hr>
                    <p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/templates/frame 3/whatsapp" alt="">{{ contacts }}</p>
                    <p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/templates/frame 3/facebook" alt="">Murphy_design_2001</p>
                    <p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/templates/frame 3/instagram" alt="">Murphy_design_2001</p>
                </div>
            </div>
            <div style="width: 59%;">
                <div>
                    <p style="font-size: 35px; font-weight: 800;">{{ companyName }}</p>
                </div>
                <div id="about">
                    <p style="font-size: 15px; font-weight: 500; color: #776CE2;">ABOUT ME</p>
                    <p style="font-size: 10px; font-weight: 400;">{{ selfDescription }}</p>
                </div>
                <div>
                    <p style="font-size: 15px; font-weight: 500;">About me</p>
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
    name: 'Frame4',
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
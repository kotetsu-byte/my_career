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
                    <p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/templates/frame 5/whatsapp.png" alt="">{{ contacts }}</p>
                    <p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/templates/frame 5/facebook.png" alt="">Murphy_design_2001</p>
                    <p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/templates/frame 5/instagram.png" alt="">Murphy_design_2001</p>
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
    name: 'Frame5',
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
.grid-div {
    display: grid;
    grid-template-columns: 59% 39%;
}
</style>
<template>
    <div class="container">
        <div class="grid-div">
            <div style="width: 95%;">
                <p style="font-size: 30px; font-weight: 500;"><span style="color: #FFC905">{{ firstName }}</span><br><span style="font-weight: 700;">{{ lastName || lastName }}</span></p>
                <p style="font-size: 15px; font-weight: 500;">{{ position }}</p>
                <div class="flex-div">
                    <div>
                        <p style="font-size: 11px; font-weight: 500;">Phone:</p>
                        <p style="font-size: 10px; font-weight: 300;">{{ phoneNumber }}</p>
                    </div>
                    <div>
                        <p style="font-size: 11px; font-weight: 500;">E-mail:</p>
                        <p style="font-size: 10px; font-weight: 300;">{{ email }}</p>
                    </div>
                </div>
                <p style="font-size: 11px; font-weight: 500;">Address:</p>
                <p style="font-size: 10px; font-weight: 300;">{{ country }} {{ region }} {{ street }}</p>
            </div>
            <div style="background-color: #FFC905; width: 39%;">
                <img :src="photo" alt="" height="200" width="200">
            </div>
            <div style="background-color: #2B3036; width: 95%; color: white;">
                <div id="skills">
                    <p style="font-size: 20px; font-weight: 400;">SKILLS</p>
                    <p style="font-size: 10px; font-weight: 400;">{{ skills }}</p>
                    <p style="font-size: 10px; font-weight: 400;">Figma</p>
                    <p style="font-size: 10px; font-weight: 400;">Adobe xd</p>
                </div>
                <div id="education">
                    <p style="font-size: 20px; font-weight: 400;">EDUCATION</p>
                    <div v-for="(item, index) in education" :key="index">
                        <p style="font-size: 10px; font-weight: 400;">{{ item.from }} - {{ item.to }}</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ item.schoolName }}</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ item.degree }}</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ item.typeOfStudy }}</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ item.location }}</p>
                    </div>
                </div>
                <div id="experience">
                    <p style="font-size: 20px; font-weight: 400;">EXPERIENCE</p>
                    <div v-for="(item, index) in experience" :key="index">
                        <p style="font-size: 10px; font-weight: 400;">{{ item.from }} - {{ item.to }}</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ item.companyName }}</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ item.job }}</p>
                        <p style="font-size: 10px; font-weight: 400;">{{ item.description }}</p>
                    </div>
                </div>
                <div id="languages">
                    <p style="font-size: 20px; font-weight: 400;">LANGUAGES</p>
                    <div v-for="(item, index) in languages" :key="index">
                        <p style="font-size: 10px; font-weight: 400;">{{ item.language }} - {{ item.level }}</p>
                    </div>
                    <p style="font-size: 10px; font-weight: 400;">French</p>
                    <p style="font-size: 10px; font-weight: 400;">Korean</p>
                    <p style="font-size: 10px; font-weight: 400;">Uzbek</p>
                </div>
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
                <div id="hobbies">
                    <p style="font-size: 20px; font-weight: 400;">HOBBIES</p>
                    <p style="font-size: 10px; font-weight: 400;">{{ hobbies }}</p>
                    <p style="font-size: 10px; font-weight: 400;">Chess</p>
                    <p style="font-size: 10px; font-weight: 400;">Football</p>
                    <p style="font-size: 10px; font-weight: 400;">Travelling</p>
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
        photo: String,
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
        selfDescription: String,
        languages: Array,
        experience: Array,
        education: Array,
        contacts: String
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
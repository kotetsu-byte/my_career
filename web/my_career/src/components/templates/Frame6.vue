<template>
    <div class="container">
        <div class="grid-div">
            <div>
                <p style="font-size: 25px; font-weight: 600;">MICHEL RIGAURIO</p>
                <p style="font-size: 15px; font-weight: 500;">UI/UX Designer</p>
                <div class="flex-div">
                    <div>
                        <p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/templates/frame 6/tel.png" alt="">+99890 000 00 00</p>
                    </div>
                    <div>
                        <p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/templates/frame 6/email.png" alt="">user@name.com</p>
                    </div>
                </div>
                <p style="font-size: 10px; font-weight: 400;">
                    <img src="../../assets/icons/templates/frame 6/geo.png" alt="">Tashkent Uchtepa Kokcha-oqtepa pr3 344
                </p>
            </div>
            <div>
                <img src="../../assets/img/templates/frame-6-photo.png" alt="">
            </div>
            <div>
                <div id="about">
                    <p style="background-color: #C7DAE0; font-size: 15px; font-weight: 500;">ABOUT ME</p>
                    <p style="font-size: 12px; font-weight: 400;">Everything is a bit different nowadays. The word "art" has a special meaning. It means something beautiful. The paintings of skilled Everything is a bit different nowadays. The word "art" has a special meaning. It means something beautiful.</p>
                </div>
                <div id="language">
                    <p style="background-color: #C7DAE0; font-size: 15px; font-weight: 500;">LANGUAGE</p>
                    <p style="font-size: 12px; font-weight: 400;">ENGLISH</p>
                    <p style="font-size: 12px; font-weight: 400;">FRENCH</p>
                    <p style="font-size: 12px; font-weight: 400;">GERMAN</p>
                </div>
                <div id="skills">
                    <p style="background-color: #C7DAE0; font-size: 15px; font-weight: 500;">SKILLS</p>
                    <p style="font-size: 12px; font-weight: 400;">PHOTOSHOP</p>
                    <p style="font-size: 12px; font-weight: 400;">FIGMA</p>
                    <p style="font-size: 12px; font-weight: 400;">ADOBE XD</p>
                </div>
                <div id="hobbies">
                    <p style="background-color: #C7DAE0; font-size: 15px; font-weight: 500;">HOBBIES</p>
                    <p style="font-size: 12px; font-weight: 400;">PHOTOSHOP</p>
                    <p style="font-size: 12px; font-weight: 400;">FIGMA</p>
                    <p style="font-size: 12px; font-weight: 400;">ADOBE XD</p>
                </div>
            </div>
            <div>
                <div id="education">
                    <p style="background-color: #C7DAE0; font-size: 15px; font-weight: 500;">EDUCATION</p>
                    <p style="font-size: 12px; font-weight: 400;">Name Of Degree (2021-2022)</p>
                    <p style="font-size: 12px; font-weight: 400;">Name Of university</p>
                    <p style="font-size: 12px; font-weight: 400;">Everything is a bit different nowadays. The word "art" has a special meaning. It means something beautiful.</p>
                    <p style="font-size: 12px; font-weight: 400;">Name Of Degree (2021-2022)</p>
                    <p style="font-size: 12px; font-weight: 400;">Name Of university</p>
                    <p style="font-size: 12px; font-weight: 400;">Everything is a bit different nowadays. The word "art" has a special meaning. It means something beautiful.</p>
                </div>
                <div id="experience">
                    <p style="font-size: 12px; font-weight: 400;">Name Of Degree (2021-2022)</p>
                    <p style="font-size: 12px; font-weight: 400;">Name Of company</p>
                    <p style="font-size: 12px; font-weight: 400;">Everything is a bit different nowadays. The word "art" has a special meaning. It means something beautiful.</p>
                </div>
                <div id="contacts">
                    <p style="background-color: #C7DAE0; font-size: 15px; font-weight: 500;">CONTACTS</p>
                    <p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/templates/frame 6/whatsapp.png" alt="">Murphy_design_2001</p>
                    <p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/templates/frame 6/facebook.png" alt="">Murphy_design_2001</p>
                    <p style="font-size: 12px; font-weight: 400;"><img src="../../assets/icons/templates/frame 6/instagram.png" alt="">Murphy_design_2001</p>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'Frame6',
    components: {}
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
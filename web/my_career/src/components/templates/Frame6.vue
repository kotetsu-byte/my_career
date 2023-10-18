<template>
    <div class="container">
        <div class="grid-div">
            <div>
                <p>MICHEL RIGAURIO</p>
                <p>UI/UX Designer</p>
                <div class="flex-div">
                    <div>
                        <p><img src="../../assets/icons/templates/frame 6/tel.png" alt="">+99890 000 00 00</p>
                    </div>
                    <div>
                        <p><img src="../../assets/icons/templates/frame 6/email.png" alt="">user@name.com</p>
                    </div>
                </div>
                <p>
                    <img src="../../assets/icons/templates/frame 6/geo.png" alt="">Tashkent Uchtepa Kokcha-oqtepa pr3 344
                </p>
            </div>
            <div>
                <img src="../../assets/img/templates/frame-6-photo.png" alt="">
            </div>
            <div>
                <div id="about">
                    <p>ABOUT ME</p>
                    <p>Everything is a bit different nowadays. The word "art" has a special meaning. It means something beautiful. The paintings of skilled Everything is a bit different nowadays. The word "art" has a special meaning. It means something beautiful.</p>
                </div>
                <div id="language">
                    <p>LANGUAGE</p>
                    <p>ENGLISH</p>
                    <p>FRENCH</p>
                    <p>GERMAN</p>
                </div>
                <div id="skills">
                    <p>SKILLS</p>
                    <p>PHOTOSHOP</p>
                    <p>FIGMA</p>
                    <p>ADOBE XD</p>
                </div>
                <div id="hobbies">
                    <p>HOBBIES</p>
                    <p>PHOTOSHOP</p>
                    <p>FIGMA</p>
                    <p>ADOBE XD</p>
                </div>
            </div>
            <div>
                <div id="education">
                    <p>EDUCATION</p>
                    <p>Name Of DEgree (2021-2022)</p>
                    <p>Name Of university</p>
                    <p>Everything is a bit different nowadays. The word "art" has a special meaning. It means something beautiful.</p>
                    <p>Name Of DEgree (2021-2022)</p>
                    <p>Name Of university</p>
                    <p>Everything is a bit different nowadays. The word "art" has a special meaning. It means something beautiful.</p>
                </div>
                <div id="experience">
                    <p>Name Of DEgree (2021-2022)</p>
                    <p>Name Of university</p>
                    <p>Everything is a bit different nowadays. The word "art" has a special meaning. It means something beautiful.</p>
                </div>
                <div id="contacts">
                    <p><img src="../../assets/icons/templates/frame 6/whatsapp.png" alt="">Murphy_design_2001</p>
                    <p><img src="../../assets/icons/templates/frame 6/facebook.png" alt="">Murphy_design_2001</p>
                    <p><img src="../../assets/icons/templates/frame 6/instagram.png" alt="">Murphy_design_2001</p>
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
    height: 850px;
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
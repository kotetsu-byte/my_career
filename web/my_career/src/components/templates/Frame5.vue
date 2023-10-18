<template>
    <div class="container">
        <div class="grid-div">
            <div>
                <p>MICHEL RIGAURIO</p>
                <p>UI/UX Designer</p>
                <div class="flex-div">
                    <div>
                        <p>Phone:</p>
                        <p>+99890 000 00 00</p>
                    </div>
                    <div>
                        <p>E-mail:</p>
                        <p>user@name.com</p>
                    </div>
                </div>
                <p>Address:</p>
                <p>Taskkent Uchtepa Kokcha-oqtepa pr3 344</p>
            </div>
            <div style="background-color: #FFC905;">
                <img src="../../assets/img/templates/frame-5-photo.png" alt="">
            </div>
            <div style="background-color: #2B3036;">
                <div id="skills">
                    <p>SKILLS</p>
                    <p>Photoshop</p>
                    <p>Figma</p>
                    <p>Adobe xd</p>
                </div>
                <div id="education">
                    <p>EDUCATION</p>
                    <p>2012 - 2014</p>
                    <p>Degree Name</p>
                    <p>University name here</p>
                </div>
                <div id="experience">
                    <p>EXPERIENCE</p>
                    <p>2019 - Present  </p>
                    <p>Enter Job</p>
                    <p>Company Name</p>
                    <p>Everything is a bit different nowadays. The word "art" has a special meaning. It means something beautiful.</p>
                </div>
                <div id="languages">
                    <p>English</p>
                    <p>French</p>
                    <p>Korean</p>
                    <p>Uzbek</p>
                </div>
                <div id="cotacts">
                    <p><img src="../../assets/icons/templates/frame 5/whatsapp.png" alt="">Murphy_design_2001</p>
                    <p><img src="../../assets/icons/templates/frame 5/facebook.png" alt="">Murphy_design_2001</p>
                    <p><img src="../../assets/icons/templates/frame 5/instagram.png" alt="">Murphy_design_2001</p>
                </div>
            </div>
            <div>
                <div id="about">
                    <p>ABOUT ME</p>
                    <p>Everything is a bit different nowadays. The word "art" has a special meaning. It means something beautiful. The paintings of skilled painters are appreciated and admired by millions of people today, by those who can see the beauty.</p>
                </div>
                <div id="hobbies">
                    <p>HOBBIES</p>
                    <p>Music</p>
                    <p>Chess</p>
                    <p>Football</p>
                    <p>Travelling</p>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'Frame5',
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
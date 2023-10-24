<template>
    <div class="container">
        <div class="grid-div">
            <div style="width: 95%;">
                <p style="font-size: 30px; font-weight: 500;"><span style="color: #FFC905">MICHEL</span><br><span style="font-weight: 700;">RIGAURIO</span></p>
                <p style="font-size: 15px; font-weight: 500;">UI/UX Designer</p>
                <div class="flex-div">
                    <div>
                        <p style="font-size: 11px; font-weight: 500;">Phone:</p>
                        <p style="font-size: 10px; font-weight: 300;">+99890 000 00 00</p>
                    </div>
                    <div>
                        <p style="font-size: 11px; font-weight: 500;">E-mail:</p>
                        <p style="font-size: 10px; font-weight: 300;">user@name.com</p>
                    </div>
                </div>
                <p style="font-size: 11px; font-weight: 500;">Address:</p>
                <p style="font-size: 10px; font-weight: 300;">Taskkent Uchtepa Kokcha-oqtepa pr3 344</p>
            </div>
            <div style="background-color: #FFC905; width: 39%;">
                <img src="../../assets/img/templates/frame-5-photo.png" alt="">
            </div>
            <div style="background-color: #2B3036; width: 95%; color: white;">
                <div id="skills">
                    <p style="font-size: 20px; font-weight: 400;">SKILLS</p>
                    <p style="font-size: 10px; font-weight: 400;">Photoshop</p>
                    <p style="font-size: 10px; font-weight: 400;">Figma</p>
                    <p style="font-size: 10px; font-weight: 400;">Adobe xd</p>
                </div>
                <div id="education">
                    <p style="font-size: 20px; font-weight: 400;">EDUCATION</p>
                    <p style="font-size: 10px; font-weight: 400;">2012 - 2014</p>
                    <p style="font-size: 10px; font-weight: 400;">Degree Name</p>
                    <p style="font-size: 10px; font-weight: 400;">University name here</p>
                </div>
                <div id="experience">
                    <p style="font-size: 20px; font-weight: 400;">EXPERIENCE</p>
                    <p>2019 - Present</p>
                    <p>Enter Job</p>
                    <p>Company Name</p>
                    <p>Everything is a bit different nowadays. The word "art" has a special meaning. It means something beautiful.</p>
                </div>
                <div id="languages">
                    <p style="font-size: 20px; font-weight: 400;">LANGUAGES</p>
                    <p style="font-size: 10px; font-weight: 400;">English</p>
                    <p style="font-size: 10px; font-weight: 400;">French</p>
                    <p style="font-size: 10px; font-weight: 400;">Korean</p>
                    <p style="font-size: 10px; font-weight: 400;">Uzbek</p>
                </div>
                <div id="cotacts">
                    <p style="font-size: 20px; font-weight: 400;">CONTACTS</p>
                    <p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/templates/frame 5/whatsapp.png" alt="">Murphy_design_2001</p>
                    <p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/templates/frame 5/facebook.png" alt="">Murphy_design_2001</p>
                    <p style="font-size: 10px; font-weight: 400;"><img src="../../assets/icons/templates/frame 5/instagram.png" alt="">Murphy_design_2001</p>
                </div>
            </div>
            <div style="width: 39%;">
                <div id="about">
                    <p style="font-size: 20px; font-weight: 400;">ABOUT ME</p>
                    <p style="font-size: 10px; font-weight: 400;">Everything is a bit different nowadays. The word "art" has a special meaning. It means something beautiful. The paintings of skilled painters are appreciated and admired by millions of people today, by those who can see the beauty.</p>
                </div>
                <div id="hobbies">
                    <p style="font-size: 20px; font-weight: 400;">HOBBIES</p>
                    <p style="font-size: 10px; font-weight: 400;">Music</p>
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
    name: 'Frame5',
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
    grid-template-columns: 59% 39%;
}
</style>
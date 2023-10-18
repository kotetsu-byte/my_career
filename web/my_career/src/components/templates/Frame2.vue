<template>
    <div class="container">
        <div id="header" style="background-color: #171B26;">
            <div class="flex-div">
                <div>
                    <div style="height: 100%; background-color: #747474;">
                        <img src="../../assets/img/templates/frame-1-photo.png" alt="">
                    </div>
                </div>
                <div>
                    <p id="full-name">John Smith</p>
                    <p id="position" style="background-color: #42454E;">Marketing Specialist</p>
                    <br><br>
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
                    <p>Tashkent Uchtepa Kokcha-oqtepa pr3 344</p>
                </div>
            </div>
        </div>
        <div id="main">
            <div class="flex-div" style="align-items: start;">
                <div style="background-color: #747474;">
                    <div id="skills">
                        <p>Skills</p>
                        <p>Photoshop</p>
                        <p>Figma</p>
                        <p>Adobe XD</p>
                    </div>
                    <div id="languages">
                        <p>Languages</p>
                        <p>English - level</p>
                        <p>French - level</p>
                        <p>Korean - level</p>
                        <p>Uzbek - level</p>
                    </div>
                    <div id="hobbies">
                        <p>Hobbies</p>
                        <ul>
                            <li>Travelling</li>
                            <li>Football</li>
                            <li>Music</li>
                            <li>Chess</li>
                        </ul>
                    </div>
                    <div id="contacts">
                        <p>Contacts</p>
                        <p><img src="../../assets/icons/templates/frame 1/whatsapp" alt="">Murphy_design_2001</p>
                        <p><img src="../../assets/icons/templates/frame 1/facebook" alt="">Murphy_design_2001</p>
                        <p><img src="../../assets/icons/templates/frame 1/instagram" alt="">Murphy_design_2001</p>
                    </div>
                </div>
                <div>
                    <div id="about">
                        <p>About me</p>
                        <p>In my current position at ABC, I have supervised all phases of our online marketing initiatives, both technical and creative. Last year, my key challeng was to design and optimize nine product websites for ABC's most strategic products and improve our SO results as well as enhance the UX. Here we are a year later:</p>
                    </div>
                    <div id="education">
                        <p>Education</p>
                        <div class="flex-div" style="align-items: start;">
                            <div>
                                <p>2012 - 2014</p>
                                <p>University name</p>
                            </div>
                            <div>
                                <p>Degree Name</p>
                                <p>Lorem Ipsum Issyk simply dummy text offset the printing and typesetting industry.</p>
                            </div>
                        </div>
                    </div>
                    <div id="experience">
                        <p>Experience</p>
                        <div class="flex-div" style="align-items: start;">
                            <div>
                                <p>2020 - Present</p>
                                <p>Company Name</p>
                            </div>
                            <div>
                                <p>Senior UX Designer</p>
                                <p>Lorem Ipsum Issyk simply dummy text offset the printing and typesetting industry.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'Frame2',
    components: {}
}
</script>

<style scoped>
.container {
    width: 600px;
    height: 850px;
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
    padding: 40px 0;
}
.flex-div {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-self: center;
}
</style>
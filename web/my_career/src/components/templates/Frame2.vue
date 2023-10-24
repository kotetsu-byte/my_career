<template>
    <div class="container">
        <div id="header" style="background-color: #171B26;">
            <div class="flex-div" style="justify-content: start;">
                <div style="width: 39%;">
                    <div style="height: 100%; background-color: #747474;">
                        <img src="../../assets/img/templates/frame-1-photo.png" alt="" style="width: 100%;">
                    </div>
                </div>
                <div style="width: 59%; padding-left: 30px;">
                    <p id="full-name" style="font-size: 35px; font-weight: 700; color: white; margin: 10px 0;">John Smith</p>
                    <p id="position" style="background-color: #42454E; width: max-content; padding: 1px 5px; color: white; font-size: 20px; font-weight: 700;">Marketing Specialist</p>
                    <br><br>
                    <div class="flex-div" style="justify-content: start;">
                        <div style="margin: 10px 0;">
                            <p style="color: white; font-size: 12px; font-weight: 500;">Phone:</p>
                            <p style="color: #E5E5E5; font-size: 10px; font-weight: 300;">+99890 000 00 00</p>
                        </div>
                        <div style="margin: 10px 0; margin-left: 10px;">
                            <p style="color: white; font-size: 12px; font-weight: 500;">E-mail:</p>
                            <p style="color: #E5E5E5; font-size: 10px; font-weight: 300;">user@name.com</p>
                        </div>
                    </div>
                    <p style="color: white; font-size: 12px; font-weight: 500;">Address:</p>
                    <p style="color: #E5E5E5; font-size: 10px; font-weight: 300;">Tashkent Uchtepa Kokcha-oqtepa pr3 344</p>
                </div>
            </div>
        </div>
        <div id="main">
            <div class="flex-div" style="align-items: start;">
                <div style="background-color: #747474; width: 39%;">
                    <div id="skills">
                        <p style="font-size: 20px; font-weight: 700;">Skills</p>
                        <p style="font-size: 10px; font-weight: 400;">Photoshop</p>
                        <p style="font-size: 10px; font-weight: 400;">Figma</p>
                        <p style="font-size: 10px; font-weight: 400;">Adobe XD</p>
                    </div>
                    <div id="languages">
                        <p style="font-size: 20px; font-weight: 700;">Languages</p>
                        <p style="font-size: 10px; font-weight: 400;">English - level</p>
                        <p style="font-size: 10px; font-weight: 400;">French - level</p>
                        <p style="font-size: 10px; font-weight: 400;">Korean - level</p>
                        <p style="font-size: 10px; font-weight: 400;">Uzbek - level</p>
                    </div>
                    <div id="hobbies">
                        <p style="font-size: 20px; font-weight: 700;">Hobbies</p>
                        <ul style="padding-left: 20px;">
                            <li style="font-size: 11px; font-weight: 500;">Travelling</li>
                            <li style="font-size: 11px; font-weight: 500;">Football</li>
                            <li style="font-size: 11px; font-weight: 500;">Music</li>
                            <li style="font-size: 11px; font-weight: 500;">Chess</li>
                        </ul>
                    </div>
                    <div id="contacts">
                        <p style="font-size: 20px; font-weight: 700;">Contacts</p>
                        <p><img src="../../assets/icons/templates/frame 1/whatsapp" alt=""><span style="font-size: 10px; font-weight: 500;">Murphy_design_2001</span></p>
                        <p><img src="../../assets/icons/templates/frame 1/facebook" alt=""><span style="font-size: 10px; font-weight: 500;">Murphy_design_2001</span></p>
                        <p><img src="../../assets/icons/templates/frame 1/instagram" alt=""><span style="font-size: 10px; font-weight: 500;">Murphy_design_2001</span></p>
                    </div>
                </div>
                <div style="width: 59%;">
                    <div id="about">
                        <p style="font-size: 20px; font-weight: 700;">About me</p>
                        <p style="font-size: 10px; font-weight: 400;">In my current position at ABC, I have supervised all phases of our online marketing initiatives, both technical and creative. Last year, my key challeng was to design and optimize nine product websites for ABC's most strategic products and improve our SO results as well as enhance the UX. Here we are a year later:</p>
                    </div>
                    <div id="education">
                        <p style="font-size: 20px; font-weight: 700;">Education</p>
                        <div class="flex-div" style="align-items: start;">
                            <div>
                                <p style="font-size: 10px; font-weight: 400;">2012 - 2014</p>
                                <p style="font-size: 10px; font-weight: 400;">University name</p>
                            </div>
                            <div>
                                <p style="font-size: 10px; font-weight: 500;">Degree Name</p>
                                <p style="font-size: 10px; font-weight: 400;">Lorem Ipsum Issyk simply dummy text offset the printing and typesetting industry.</p>
                            </div>
                        </div>
                    </div>
                    <div id="experience">
                        <p style="font-size: 20px; font-weight: 700;">Experience</p>
                        <div class="flex-div" style="align-items: start;">
                            <div>
                                <p style="font-size: 10px; font-weight: 400;">2020 - Present</p>
                                <p style="font-size: 10px; font-weight: 400;">Company Name</p>
                            </div>
                            <div>
                                <p style="font-size: 10px; font-weight: 500;">Senior UX Designer</p>
                                <p style="font-size: 10px; font-weight: 400;">Lorem Ipsum Issyk simply dummy text offset the printing and typesetting industry.</p>
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
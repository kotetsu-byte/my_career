<template>
    <div class="container">
        <header>
            <div class="flex-div">
                <div style="width: 39%;">
                    <img src="../../assets/img/templates/frame-1-photo.png" alt="">
                </div>
                <div style="width: 59%;">
                    <p id="full-name" style="font-size: 32px; font-weight: 700;">John Smith</p>
                    <p id="position" style="font-size: 15px; font-weight: 400;">Marketing Specialist</p>
                    <br><br>
                    <img src="../../assets/icons/templates/frame 1/tel.png" alt="">
                    <span style="font-size: 12px; font-weight: 400;">+99890 000 00 00</span><br>
                    <img src="../../assets/icons/templates/frame 1/email.png" alt="">
                    <span style="font-size: 12px; font-weight: 400;">user@name.com</span><br>
                    <img src="../../assets/icons/templates/frame 1/geo.png" alt="">
                    <span style="font-size: 12px; font-weight: 400;">Tashkent Uchtepa Kokcha-oqtepa pr3 344</span>
                </div>
            </div>
        </header>
        <hr style="margin: 0 10px;">
        <main>
            <div class="flex-div" style="align-items: start;">
                <div style="width: 39%;" id="for-hr">
                    <div id="skills">
                        <p style="font-size: 22px; font-weight: 700;">Skills</p>
                        <p style="font-size: 12px; font-weight: 400;">Photoshop</p>
                        <p style="font-size: 12px; font-weight: 400;">Figma</p>
                        <p style="font-size: 12px; font-weight: 400;">Adobe XD</p>
                    </div>
                    <div id="languages">
                        <p style="font-size: 22px; font-weight: 700;">Languages</p>
                        <p style="font-size: 12px; font-weight: 400;">English - level</p>
                        <p style="font-size: 12px; font-weight: 400;">French - level</p>
                        <p style="font-size: 12px; font-weight: 400;">Korean - level</p>
                        <p style="font-size: 12px; font-weight: 400;">Uzbek - level</p>
                    </div>
                    <div id="hobbies">
                        <p style="font-size: 22px; font-weight: 700;">Hobbies</p>
                        <ul>
                            <li style="font-size: 12px; font-weight: 400;">Travelling</li>
                            <li style="font-size: 12px; font-weight: 400;">Football</li>
                            <li style="font-size: 12px; font-weight: 400;">Music</li>
                            <li style="font-size: 12px; font-weight: 400;">Chess</li>
                        </ul>
                    </div>
                    <div id="contacts">
                        <p style="font-size: 22px; font-weight: 700;">Contacts</p>
                        <p><img src="../../assets/icons/templates/frame 1/whatsapp" alt=""><span style="font-size: 12px; font-weight: 400;">Murphy_design_2001</span></p>
                        <p><img src="../../assets/icons/templates/frame 1/facebook" alt=""><span style="font-size: 12px; font-weight: 400;">Murphy_design_2001</span></p>
                        <p><img src="../../assets/icons/templates/frame 1/instagram" alt=""><span style="font-size: 12px; font-weight: 400;">Murphy_design_2001</span></p>
                    </div>
                </div>
                <hr id="vertical-hr">
                <div style="width: 59%;">
                    <div id="about">
                        <p style="font-size: 22px; font-weight: 700;">About me</p>
                        <p style="font-size: 10px; font-weight: 400;">In my current position at ABC, I have supervised all phases of our online marketing initiatives, both technical and creative. Last year, my key challeng was to design and optimize nine product websites for ABC's most strategic products and improve our SO results as well as enhance the UX. Here we are a year later:</p>
                    </div>
                    <div id="education">
                        <p style="font-size: 22px; font-weight: 700;">Education</p>
                        <div class="flex-div" style="align-items: start;">
                            <div style="width: 40%;">
                                <p style="font-size: 12px; font-weight: 400;">2012 - 2014</p>
                                <p style="font-size: 12px; font-weight: 400;">University name</p>
                            </div>
                            <div>
                                <p style="font-size: 10px; font-weight: 500;">Degree Name</p>
                                <p style="font-size: 10px; font-weight: 400;">Lorem Ipsum Issyk simply dummy text offset the printing and typesetting industry.</p>
                            </div>
                        </div>
                    </div>
                    <div id="experience">
                        <p style="font-size: 22px; font-weight: 700;">Experience</p>
                        <div class="flex-div" style="align-items: start;">
                            <div style="width: 40%;">
                                <p style="font-size: 12px; font-weight: 400;">2020 - Present</p>
                                <p style="font-size: 12px; font-weight: 400;">Company Name</p>
                            </div>
                            <div>
                                <p style="font-size: 10px; font-weight: 500;">Senior UX Designer</p>
                                <p style="font-size: 10px; font-weight: 500;">Lorem Ipsum Issyk simply dummy text offset the printing and typesetting industry.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </main>
    </div>
</template>

<script>
export default {
    name: 'Frame1',
    components: {},
    data() {
        return {
            
        }
    },
    methods: {
        setVerticalHrWith() {
            var height = document.getElementById("for-hr").offsetHeight;
            console.log(height);
            document.getElementById("vertical-hr").style.height = height + 'px';
        }
    },
    computed: {
        
    },
    mounted() {
        this.setVerticalHrWith();
    }
}
</script>

<style scoped>
.container {
    width: 600px;
    min-width: 600px;
    height: max-content;
    border-radius: 12px;
}

header {
    padding: 10px 40px;
}

main {
    padding: 10px 40px;
}

.vertical {
    height: max-content;
    height: 100vh;
    margin: 0;
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
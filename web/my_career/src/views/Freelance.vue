<template> 
    <div id="cont">
        <Component1 /> 
        <Component2 />
        <Component3 />
        <Component4 />
        <Component5 />
        <Component6 />
        <Component7 />
        <Component8 />
        <button>Back to log in</button>
        <div class="container" id="section-1">
            <div style="text-align: center; margin-bottom: 10px;">
                <img src="../assets/icons/photo/photo.png" alt="">
                <p style="font-size: 18px; font-weight: 500; color: #808080;">Add your profile photo</p>
            </div>
            <div class="flex-div" style="margin: 10px 0;">
                <div style="margin-right: 10px;">
                    <label for=""><span style="font-size: 18px; font-weight: 500; color: #323232;">First name*</span></label><br>
                    <input type="text" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
                </div>
                <div>
                    <label for=""><span style="font-size: 18px; font-weight: 500; color: #323232;">Last name*</span></label><br>
                    <input type="text" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
                </div>
            </div>
            <div class="flex-div" style="margin: 5px 0;">
                <div style="margin-right: 10px;">
                    <label for=""><span style="font-size: 18px; font-weight: 500; color: #323232;">E-mail*</span></label><br>
                    <input type="email" name="" id="" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
                </div>
                <div>
                    <label for=""><span style="font-size: 18px; font-weight: 500; color: #323232;">Phone number*</span></label><br>
                    <input type="tel" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
                </div>    
            </div>
            <div style="text-align: right;">
                <button @click="next(2)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Next</button>    
            </div>
        </div>
        <div class="container" id="section-2">
            <p style="font-size: 30px; font-weight: 700; margin-bottom: 10px;">Welcome dilmurod</p>
            <p style="font-size: 18px; font-weight: 500; color: #323232; margin-bottom: 10px;">Complete your profile to join our global community of freelancers and start selling your services to our growing network of businesses.</p>
            <label for=""><span style="font-size: 18px; font-weight: 500; color: #323232;">Living address</span></label>
            <div class="flex-div" style="margin: 10px 0;">
                <div style="margin-right: 10px 0;">
                    <input type="text" placeholder="Country*" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
                </div>
                <div>
                    <input type="text" placeholder="Region*" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
                </div>
            </div>
            <input type="text" placeholder="Street, apartment" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 90%;"><br>
            <div style="text-align: right;">
                <button @click="prev(1)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Back</button>
                <button @click="next(3)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Next</button>
            </div>
        </div>
        <div class="container" id="section-3">
            <p>Write a little about yourself</p>
            <div class="flex-div">
                <div style="margin-right: 10px 0;">
                    <label for="">Write your position*</label><br>
                    <input type="text" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
                </div>
                <div>
                    <label for="">Date of birth*</label><br>
                    <input type="date" name="" id="" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
                </div>
            </div>
            <label for="">Write down your skills*</label><br>
            <input type="text" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 90%;"><br>
            <label for="">Hobbies</label><br>
            <input type="text" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 90%;"><br>
            <textarea name="" id="" cols="30" rows="10" placeholder="Describe yourself to buyers" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 90%; height: 200px; resize: none;"></textarea>
            <div style="text-align: right;">
                <button @click="prev(2)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Back</button>
                <button @click="next(4)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Next</button>
            </div>
        </div>
        <div class="container" id="section-4">
            <p>Write language you speak</p>
            <p>The more languages ​​you know, the more foreign employers will contact you.</p>
            <label for="">Language*</label>
            <div class="language">
                <div class="flex-div">
                    <div style="margin-right: 10px 0;">
                        <input type="text" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
                    </div>
                    <div>
                        <input type="text" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
                    </div>
                </div>
            </div>
            <button>+ Add new</button><br>
            <div style="text-align: right;">
                <button @click="prev(3)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Back</button>
                <button @click="next(5)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Next</button>
            </div>
        </div>
        <div class="container" id="section-5">
            <p>Work Experience</p>
            <p>Freelancers who add their experience are twice as likely to win work. But if you’re just starting out, you can still create a great profile. Just head on to the next page.</p>
            <div class="job">
                <p>NAPA Automotive</p>
                <p>UX UI Designer</p>
                <button>Edit</button>
                <button>Delete</button>
            </div>
            <button>+ Add new</button><br>
            <div style="text-align: right;">
                <button @click="prev(4)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Back</button>
                <button @click="next(6)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Next</button>
            </div>
        </div>
        <div class="container" id="section-6">
            <p>Educations</p>
            <p>Freelancers who add their experience are twice as likely to win work. But if you’re just starting out, you can still create a great profile. Just head on to the next page.</p>
            <div class="education">
                <p>TATU</p>
                <p>Bachelor</p>
                <p></p>
                <p>Telecommunication</p>
                <button>Edit</button>
                <button>Delete</button>
            </div>
            <button>+ Add new</button><br>
            <div style="text-align: right;">
                <button @click="prev(5)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Back</button>
                <button @click="next(7)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Next</button>
            </div>
        </div>
        <div class="container" id="section-7">
            <p>Contacts</p>
            <input type="url" name="" id="" placeholder="Provide a link to your website ">
            <p>Choose in which of these social networks you have an account</p>
            <div class="grid-div">
                <div><img src="../assets/icons/contacts/whatsapp.png" alt=""><p>WhatsApp</p></div>
                <div><img src="../assets/icons/contacts/facebook.png" alt=""><p>Facebook</p></div>
                <div><img src="../assets/icons/contacts/instagram.png" alt=""><p>Instagram</p></div>
                <div><img src="../assets/icons/contacts/telegram.png" alt=""><p>Telegram</p></div>
                <div><img src="../assets/icons/contacts/github.png" alt=""><p>Github</p></div>
                <div><img src="../assets/icons/contacts/twitter.png" alt=""><p>Twitter</p></div>
            </div>
            <div style="text-align: right;">
                <button @click="prev(6)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Back</button>
                <button @click="next(8)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Next</button>
            </div>
        </div>
        <div class="container" id="section-8">
            <p>Select you resume Design</p>
            <p>Your resume is ready! You need to choose one of this templates and all your info will be filled in it already.</p>
            <div style="text-align: right;">
                <button @click="prev(7)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Back</button>
                <button style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Next</button>
            </div>
        </div>
    </div>
</template>

<script>
import Component1 from '../components/freelance-components/Component1.vue';
import Component2 from '../components/freelance-components/Component2.vue';
import Component3 from '../components/freelance-components/Component3.vue';
import Component4 from '../components/freelance-components/Component4.vue';
import Component5 from '../components/freelance-components/Component5.vue';
import Component6 from '../components/freelance-components/Component6.vue';
import Component7 from '../components/freelance-components/Component7.vue';
import Component8 from '../components/freelance-components/Component8.vue';

import { mapGetters, mapActions } from 'vuex';

export default {
    name: 'Freelance',
    components: {Component1, Component2, Component3, Component4, Component5, Component6, Component7, Component8},
    data() {
        return {
            sectionNo: 0
        }
    },
    methods: {
        ...mapActions(['setSectionNo']),
        next(id) {
            this.setSectionNo(id);
            document.getElementById(`section-${id-1}`).style.display = 'none';
            document.getElementById(`section-${id}`).style.display = 'block';
        },
        prev(id) {
            document.getElementById(`section-${id}`).style.display = 'block';
            document.getElementById(`section-${id+1}`).style.display = 'none';
            this.setSectionNo(id);
        },
    },
    computed: {
        ...mapGetters(['getSectionNo']),
        getNoSection() {
            this.sectionNo = this.getSectionNo;
            document.getElementById(`section-${this.sectionNo}`).style.display = 'block';
        }
    },
    mounted() {
        this.getNoSection;
    }
}
</script>

<style scoped>
#cont {
    background-color: #F4F8FB;
    height: 100vh;
}
.container {
    margin: 100px auto 0 auto;
    min-width: 400px;
    max-width: max-content;
    background-color: white;
    border-radius: 12px;
    padding: 20px;
    width: max-content;
    max-width: 500px;
}

.flex-div {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
}

.grid-div {
    display: grid;
    grid-template-columns: 1fr 1fr 1fr;
}

#section-2, #section-3, #section-4, #section-5, #section-6, #section-7, #section-8 {
    display: none;
} 
</style>
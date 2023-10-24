<template>    
    <div style="text-align: center; margin-bottom: 10px;">
        <div class="file-upload"> 
            <label for="photo-input">
                <img src="../../assets/icons/photo/photo.png" width="100" height="100" style="cursor: pointer;" alt="" id="photo">
            </label>
            <input type="file" id="photo-input" style="display: none;" @change="addPhoto">
        </div>
        <p style="font-size: 18px; font-weight: 500; color: #808080;">Add your profile photo</p>
    </div>
    <div class="flex-div" style="margin: 10px 0;">
        <div style="margin-right: 10px;">
            <label><span style="font-size: 18px; font-weight: 500; color: #323232;">First name*</span></label><br>
            <input v-model="firstName" type="text" @input="" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
        </div>
        <div>
            <label><span style="font-size: 18px; font-weight: 500; color: #323232;">Last name*</span></label><br>
            <input v-model="lastName" type="text" @input="" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
        </div>
    </div>
    <div class="flex-div" style="margin: 5px 0;">
        <div style="margin-right: 10px;">
            <label><span style="font-size: 18px; font-weight: 500; color: #323232;">E-mail*</span></label><br>
            <input v-model="email" type="email" @input="" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
        </div>
        <div>
            <label><span style="font-size: 18px; font-weight: 500; color: #323232;">Phone number*</span></label><br>
            <input v-model="phoneNumber" type="tel" @input="" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
        </div>    
    </div>
</template>

<script>
import {mapActions, mapGetters} from 'vuex';

export default {
    name: 'Component1',
    components: {},
    data() {
        return {
            photo: '',
            firstName: '',
            lastName: '',
            email: '',
            phoneNumber: ''
        }
    },
    props: {
        saveToStore: Boolean
    },
    methods: {
        ...mapActions(['setComponent1Data']),
        addPhoto() {
            var image = document.querySelector("#photo-input").files[0];
            console.log(image);
            this.photo = image;
            var reader = new FileReader();
            reader.readAsDataURL(image);
            reader.onload = function() {
                document.querySelector("#photo").src = reader.result;
                console.log(reader.result);
            }
        },
        sendComponentDataToStore() {
            var obj = {
                photo: this.photo,
                firstName: this.firstName,
                lastName: this.lastName,
                email: this.email,
                phoneNumber: this.phoneNumber
            };
            this.setComponent1Data(obj);
            this.$emit('nextPage', null);
        }
    },
    watch: {
        saveToStore: function(newVal, oldVal) {
            if(newVal == true) {
                this.sendComponentDataToStore();
            }
        }
    },
    computed: {
        ...mapGetters(['getComponent1Data']),
        getComponentData() {
            this.photo = this.getComponent1Data.photo;
            this.firstName = this.getComponent1Data.firstName;
            this.lastName = this.getComponent1Data.lastName;
            this.email = this.getComponent1Data.email;
            this.phoneNumber = this.getComponent1Data.phoneNumber;
        }
    },
    mounted() {
        this.getComponentData;
    }
}
</script>

<style scoped>
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
</style>
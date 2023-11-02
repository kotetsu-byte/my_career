<template>    
    <div class="text-center mb-10">
        <div class="file-upload"> 
            <label for="photo-input">
                <img class="pointer" :src="photo" width="100" height="100" id="photo" />
            </label>
            <input class="display-none" type="file" id="photo-input" @change="addPhoto($event)">
        </div>
        <p class="f-18-w-500 color-1">Add your profile photo</p>
    </div>
    <div ref="" class="flex-div mtb-10">
        <div class="mr-10">
            <label><span class="f-18-w-500 color-2">First name*</span></label><br>
            <input class="input" v-model="firstName" type="text">
        </div>
        <div>
            <label><span class="f-18-w-500 color-2">Last name*</span></label><br>
            <input class="input" v-model="lastName" type="text">
        </div>
    </div>
    <div class="flex-div" style="margin: 5px 0;">
        <div style="margin-right: 10px;">
            <label><span class="f-18-w-500 color-2">E-mail*</span></label><br>
            <input class="input" v-model="email" type="email">
        </div>
        <div>
            <label><span class="f-18-w-500 color-2">Phone number*</span></label><br>
            <input class="input" v-model="phoneNumber" type="tel">
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
            photo: '../../src/assets/icons/photo/photo.png',
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
        addPhoto(event) {
            let reader = new FileReader();
            reader.readAsDataURL(event.target.files[0]);
            reader.onloadend = () => {
                this.photo = reader.result;
                console.log(reader.result);
            }
        },
        saveImg() {

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
            this.$emit('nextPrevPage', null);
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

.pointer {
    cursor: pointer;
}

.display-none {
    display: none;
}

.f-18-w-500 {
    font-size: 18px; 
    font-weight: 500; 
}

.color-1 {
    color: #808080;
}

.color-2 {
    color: #323232;
}

.input {
    padding: 15px 20px; 
    border-radius: 8px; 
    border: 1px solid #CDCDCD; 
    font-size: 20px; 
    font-weight: 500; 
    width: 80%;
}

.text-center {
    text-align: center;
}

.mb-10 {
    margin-bottom: 10px;
}

.mtb-10 {
    margin: 10px 0;
}

.mr-10 {
    margin-right: 10px 0;
}
</style>
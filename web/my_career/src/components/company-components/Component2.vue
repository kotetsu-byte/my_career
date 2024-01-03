<template>
    <p class="f-30-w-700">Your company!</p>
    <div class="text-center mtb-10">
        <div class="file-upload"> 
            <label for="photo-input">
                <img class="pointer" :src="photo" width="100" height="100" id="photo">
            </label>
            <input class="display-none" type="file" id="photo-input" @change="addPhoto($event)">
        </div>
        <p class="f-18-w-500 color-1">Add your profile photo</p>
    </div>
    <label for=""><span class="f-18-w-500 color-2">Company name</span></label><br>
    <input v-model="companyName" class="input" type="text"><br>
    <label for=""><span class="f-18-w-500 color-2">Number</span></label><br>
    <input v-model="companyPhoneNumber" class="input" type="text"><br>
</template>

<script>
import {mapGetters, mapActions} from 'vuex';

export default {
    name: 'Component2',
    components: {},
    data() {
        return {
            photo: '',
            companyName: '',
            companyPhoneNumber: ''
        }
    },
    props: {
        saveToStore: Boolean
    },
    methods: {
        ...mapActions(['setComapnyComponent2Data', 'setUpdateCompanyResume']),
        sendComponentDataToStore() {
            let obj = {
                photo: this.photo,
                companyName: this.companyName,
                companyPhoneNumber: this.companyPhoneNumber
            };
            if(this.getIsUpdate === false) {
                this.setComapnyComponent2Data(obj);                
            } else {
                this.setUpdateCompanyResume(obj);
            }
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
        ...mapGetters(['getCompanyComponent2Data', 'getIsUpdate', 'getUpdateCompanyResume']),
        getComponentData() {
            if(this.getIsUpdate === false) {
                this.photo = this.getCompanyComponent2Data.photo;
                this.companyName = this.getCompanyComponent2Data.companyName;
                this.companyPhoneNumber = this.getCompanyComponent2Data.companyPhoneNumber;
            } else {
                this.photo = this.getUpdateCompanyResume.photo;
                this.companyName = this.getUpdateCompanyResume.companyName;
                this.companyPhoneNumber = this.getUpdateCompanyResume.companyPhoneNumber;
            }
        }
    },
    mounted() {
        this.getComponentData;
    }
}
</script>

<style scoped>
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
.text-center {
    text-align: center;
}

.display-none {
    display: none;
}
.mtb-10 {
    margin: 10px 0;
}

.mb-10 {
    margin-bottom: 10px;
}

.color-1 {
    color: #808080;
}

.color-2 {
    color: #323232;
}
.f-18-w-500 {
    font-size: 18px;
    font-weight: 500;
}

.f-18-w-500-c {
    font-size: 18px; 
    font-weight: 500; 
    color: #323232;
}

.f-30-w-700 {
    font-size: 30px;
    font-weight: 700;
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
    width: 90%;
}
</style>
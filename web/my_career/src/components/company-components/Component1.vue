<template>
    <p class="f-30-w-700 mb-10">Welcome</p>
    <p class="f-18-w-500-c mb-10">Complete your profile to join our global community of freelancers and start selling your services to our growing network of businesses.</p>
    <div class="flex-div" style="margin: 10px 0;">
        <div class="mr-10">
            <label for=""><span class="f-18-w-500 color-2">First name*</span></label><br>
            <input v-model="firstName" class="input" type="text">
        </div>
        <div>
            <label for=""><span class="f-18-w-500 color-2">Last name*</span></label><br>
            <input v-model="lastName" class="input" type="text">
        </div>
    </div>
    <div class="flex-div">
        <div>
            <label for=""><span class="f-18-w-500 color-2">E-mail*</span></label><br>
            <input v-model="email" class="input" type="email">
        </div>
        <div>
            <label for=""><span class="f-18-w-500 color-2">Phone number*</span></label><br>
            <input v-model="phoneNumber" class="input" type="tel">
        </div>
    </div>
</template>

<script>
import {mapGetters, mapActions} from 'vuex';

export default {
    name: 'Component1',
    components: {},
    data() {
        return {
            firstName: '',
            lastName: '',
            email: '',
            phoneNumber: '',
        }
    },
    props: {
        saveToStore: Boolean
    },
    methods: {
        ...mapActions(['setComapnyComponent1Data', 'setUpdateCompanyResume']),
        sendComponentDataToStore() {
            let obj = {
                firstName: this.firstName,
                lastName: this.lastName,
                email: this.email,
                phoneNumber: this.phoneNumber
            };
            if(this.getIsUpdate === false) {
                this.setComapnyComponent1Data(obj);
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
        ...mapGetters(['getCompanyComponent1Data', 'getIsUpdate', 'getUpdateCompanyResume']),
        getComponentData() {
            if(this.getIsUpdate === false) {
                this.firstName = this.getCompanyComponent1Data.firstName;
                this.lastName = this.getCompanyComponent1Data.lastName;
                this.email = this.getCompanyComponent1Data.email;
                this.phoneNumber = this.getCompanyComponent1Data.phoneNumber;
            } else {
                this.firstName = this.getUpdateCompanyResume.firstName;
                this.lastName = this.getUpdateCompanyResume.lastName;
                this.email = this.getUpdateCompanyResume.email;
                this.phoneNumber = this.getUpdateCompanyResume.phoneNumber;
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
.mtb-10 {
    margin: 10px 0;
}

.mb-10 {
    margin-bottom: 10px;
}

.mr-10 {
    margin-right: 10px;
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
    width: 80%;
}
</style>
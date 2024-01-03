<template>
    <p class="f-30-w-700 mtb-10">About your company</p>
    <p class="f-18-w-500-c mb-10">Write down some more information about your company</p>
    <label for=""><span class="f-18-w-500 color-2">Location*</span></label><br>
    <input v-model="address" class="input" type="text"><br>
    <label for=""><span class="f-18-w-500 color-2">Description</span></label><br>
    <input v-model="description" class="input" type="text"><br>
</template>

<script>
import {mapGetters, mapActions} from 'vuex';

export default {
    name: 'Component3',
    components: {},
    data() {
        return {
            address: '',
            description: ''
        }
    },
    props: {
        saveToStore: Boolean
    },
    methods: {
        ...mapActions(['setCompanyComponent3Data', 'setUpdateCompanyResume']),
        sendComponentDataToStore() {
            let obj = {
                address: this.address,
                description: this.description
            };
            if(this.getIsUpdate === false) {
                this.setCompanyComponent3Data(obj);
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
        ...mapGetters(['getCompanyComponent3Data', 'getIsUpdate', 'getUpdateCompanyResume']),
        getComponentData() {
            if(this.getIsUpdate === false) {
                this.address = this.getCompanyComponent3Data.address;
                this.description = this.getCompanyComponent3Data.description;
            } else {
                this.address = this.getUpdateCompanyResume.address;
                this.description = this.getUpdateCompanyResume.description;
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
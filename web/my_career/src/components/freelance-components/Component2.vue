<template>
    <p class="f-30-w-700 mb-10">Welcome dilmurod</p>
    <p class="f-18-w-500-c mb-10">Complete your profile to join our global community of freelancers and start selling your services to our growing network of businesses.</p>
    <label for=""><span class="f-18-w-500">Living address</span></label>
    <div class="flex-div mtb-10">
        <div class="mr-10">
            <input class="input w-80" type="text" v-model="country" placeholder="Country*">
        </div>
        <div>
            <input class="input w-80" type="text" v-model="region" placeholder="Region*">
        </div>
    </div>
    <input class="input w-90" type="text" v-model="street" placeholder="Street, apartment"><br>
</template>

<script>
import {mapActions, mapGetters} from 'vuex';

export default {
    name: 'Component2',
    components: {},
    data() {
        return {
            country: '',
            region: '',
            street: ''
        }
    },
    props: {
        saveToStore: Boolean
    },
    methods: {
        ...mapActions(['setComponent2Data']),
        sendComponentDataToStore() {
            var obj = {
                country: this.country,
                region: this.region,
                street: this.street
            };
            this.setComponent2Data(obj);
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
        ...mapGetters(['getComponent2Data']),
        getComponentData() {
            this.country = this.getComponent2Data.country;
            this.region = this.getComponent2Data.region;
            this.street = this.getComponent2Data.street;
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

.f-30-w-700 {
    font-size: 30px;
    font-weight: 700;
}

.mb-10 {
    margin-bottom: 10px;
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

.mtb-10 {
    margin: 10px 0;
}

.mr-10 {
    margin-right: 10px 0;
}

.input {
    padding: 15px 20px; 
    border-radius: 8px; 
    border: 1px solid #CDCDCD; 
    font-size: 20px; 
    font-weight: 500;
}

.w-80 {
    width: 80%;
}

.w-90 {
    width: 90%;
}
</style>
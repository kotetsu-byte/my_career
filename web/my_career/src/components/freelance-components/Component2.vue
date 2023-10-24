<template>
    <p style="font-size: 30px; font-weight: 700; margin-bottom: 10px;">Welcome dilmurod</p>
    <p style="font-size: 18px; font-weight: 500; color: #323232; margin-bottom: 10px;">Complete your profile to join our global community of freelancers and start selling your services to our growing network of businesses.</p>
    <label for=""><span style="font-size: 18px; font-weight: 500; color: #323232;">Living address</span></label>
    <div class="flex-div" style="margin: 10px 0;">
        <div style="margin-right: 10px 0;">
            <input type="text" v-model="country" placeholder="Country*" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
        </div>
        <div>
            <input type="text" v-model="region" placeholder="Region*" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
        </div>
    </div>
    <input type="text" v-model="street" placeholder="Street, apartment" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 90%;"><br>
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
</style>
<template>
    <p style="font-size: 30px; font-weight: 700;">Write language you speak</p>
    <p style="font-size: 18px; font-weight: 500; color: #808080;">The more languages ​​you know,<br> the more foreign employers will contact you.</p>
    <label for=""><span style="font-size: 18px; font-weight: 500;">Language*</span></label>
    <div class="language">
        <div class="flex-div">
            <div style="margin-right: 10px 0;">
                <input type="text" v-model="language" placeholder="Language" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
            </div>
            <div>
                <input type="text" v-model="level" placeholder="Level" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
            </div>
        </div>
    </div>
    <button style="padding: 15px 20px; border: 1px solid #1D71B8; border-radius: 8px; color: #1D71B8; width: 100%; margin: 10px 0; background-color: inherit;">+ Add new</button><br>
</template>

<script>
import {mapActions, mapGetters} from 'vuex';

export default {
    name: 'Component4',
    components: {},
    data() {
        return {
            language: '',
            level: ''
        }
    },
    props: {
        saveToStore: Boolean
    },
    methods: {
        ...mapActions(['setComponent4Data']),
        sendComponentDataToStore() {
            var obj = {
                language: this.language,
                level: this.level
            };
            this.setComponent4Data(obj);
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
        ...mapGetters(['getComponent4Data']),
        getComponentData() {
            this.language = this.getComponent4Data.language;
            this.level = this.getComponent4Data.level;
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
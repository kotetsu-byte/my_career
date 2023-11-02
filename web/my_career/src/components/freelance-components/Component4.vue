<template>
    <p class="f-30-w-700">Write language you speak</p>
    <p class="f-18-w-500-c">The more languages ​​you know,<br> the more foreign employers will contact you.</p>
    <label for=""><span class="f-18-w-500">Language*</span></label>
    <div class="language" v-if="languages.length == 1 ? true : false">
        <div class="flex-div">
            <div class="mr-10">
                <input class="input w-80" type="text" v-model="languages[0].language" placeholder="Language">
            </div>
            <div>
                <input class="input w-80" type="text" v-model="languages[0].level" placeholder="Level">
            </div>
        </div>
    </div>
    <div class="languages" v-if="languages.length > 1 ? true : false">
        <div class="flex-div" v-for="(item, index) in languages" :key="index">
            <div style="margin-right: 10px 0;">
                <input class="input w-80" type="text" v-model="item.language" placeholder="Language">
            </div>
            <div>
                <input class="input w-80" type="text" v-model="item.level" placeholder="Level">
            </div>
            <div>
                <button @click="removeLanguage(index)">X</button>
            </div>
        </div>
    </div>
    <button class="add-btn" @click="addNewLanguage()">+ Add new</button><br>
</template>

<script>
import {mapActions, mapGetters} from 'vuex';

export default {
    name: 'Component4',
    components: {},
    data() {
        return {
            languages: [
                {
                    language: '',
                    level: ''
                }
            ],
        }
    },
    props: {
        saveToStore: Boolean
    },
    methods: {
        ...mapActions(['setComponent4Data']),
        sendComponentDataToStore() {
            this.setComponent4Data(this.languages);
            this.$emit('nextPrevPage', null);
        },
        addNewLanguage() {
            let obj = {
                language: '',
                level: ''
            }
            this.languages.push(obj);
        },
        removeLanguage(index) {
            this.languages.splice(index, 1);
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

.f-30-w-700 {
    font-size: 30px;
    font-weight: 700;
}

.f-18-w-500-c {
    font-size: 18px; font-weight: 500; color: #323232;
}

.f-18-w-500 {
    font-size: 18px;
    font-weight: 500;
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

.add-btn {
    padding: 15px 20px; 
    border: 1px solid #1D71B8; 
    border-radius: 8px; 
    color: #1D71B8; 
    width: 100%; 
    margin: 10px 0; 
    background-color: inherit;
}
</style>
<template>
    <p style="font-size: 30px; font-weight: 700;">Work Experience</p>
    <div id="display">
        <p style="font-size: 18px; font-weight: 500; color: #808080;">Freelancers who add their experience are twice as likely to win work. But if you’re just starting out, you can still create a great profile. Just head on to the next page.</p>
        <div class="job flex-div" v-for="(item, index) in experiences" :key="index" style="border: 1px solid #CDCDCD; border-radius: 10px; padding: 10px; margin: 10px 0;">
            <div>
                <p style="font-size: 20px; font-weight: 600;">{{ item.companyName }}</p>
                <p style="font-size: 16px; font-weight: 500; color: #808080;">{{ item.position }}</p>
            </div>
            <div>
                <button @click="edit(index)" style="padding: 14px 16px; border: 1px solid #1D71B8; border-radius: 6px; margin-right: 5px;"><img src="../../assets/icons/experience_education/Edit.png" alt=""></button>
                <button @click="del(index)" style="padding: 14px 16px; border: 1px solid #1D71B8; border-radius: 6px;"><img src="../../assets/icons/experience_education/Delete.png" alt=""></button>
            </div>
        </div>
        <button @click="createNew()" style="padding: 15px 20px; border: 1px solid #1D71B8; border-radius: 8px; color: #1D71B8; width: 100%; margin: 10px 0; background-color: inherit;">+ Add new</button><br>
    </div>
    <div v-if="true" id="new" style="display: none;">
        <input v-model="template.companyName" type="text" placeholder="Company name" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 90%;"><br>
        <input v-model="template.position" type="text" placeholder="Job" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 90%;"><br>
        <input v-model="template.isWorking" type="checkbox" style="border: 1px solid #1D71B8; border-radius: 6px;"><span style="font-size: 18px; font-weight: 500;"> I am currently working in this role</span><br>
        <div class="flex-div">
            <div style="margin-right: 10px;">
                <label for="">Date from</label><br>
                <input v-model="template.begin" type="date" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 80%;">
            </div>
            <div>
                <label for="To">To</label><br>
                <input v-model="template.end" type="date" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 80%;">
            </div>
        </div>
        <textarea v-model="template.description" placeholder="Description" cols="30" rows="10" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 90%; resize: none; margin: 10px 0;"></textarea><br>
        <div style="text-align: right;">
            <button @click="cancel()" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer; margin-right: 10px;">Cancel</button>
            <button @click="save(savingMode)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Save</button>
        </div>
    </div>
</template>

<script>
import {mapActions, mapGetters} from 'vuex';

export default {
    name: 'Component5',
    components: {},
    data() {
        return {
            experiences: [
                
            ],
            template: {
                companyName: '',
                position: '',
                begin: '',
                end: '',
                description: '',
                isWorking: false,
            },
            savingMode: 0,
            experienceId: 0
        }
    },
    props: {
        saveToStore: Boolean
    },
    methods: {
        ...mapActions(['setComponent5Data', 'editComponent5DataById', 'removeComponent5DataById']),
        createNew() {
            this.savingMode = 0;
            this.$emit('hideNavigation');
            document.querySelector('#display').style.display = 'none';
            document.querySelector('#new').style.display = 'block';
        },
        save(mode) {
            switch(mode) {
                case 0:
                    {
                        let obj = {
                            companyName: this.template.companyName,
                            position: this.template.position,
                            begin: this.template.begin,
                            end: this.template.end,
                            description: this.template.description,
                            isWorking: this.template.isWorking,
                        }
                        this.setComponent5Data(obj);
                        break;
                    }
                case 1:
                    {
                        let id = this.experienceId;
                        let obj = {
                            companyName: this.template.companyName,
                            position: this.template.position,
                            begin: this.template.begin,
                            end: this.template.end,
                            description: this.template.description,
                            isWorking: this.template.isWorking,
                        }
                        this.editComponent5DataById({id: id, obj: obj});
                        break;
                    }
            }
            this.$emit('showNavigation');
            document.querySelector('#new').style.display = 'none';
            document.querySelector('#display').style.display = 'block'; 
            this.template.companyName = '';
            this.template.position = '';
            this.template.begin = '';
            this.template.end = '';
            this.template.description = '';
            this.template.isWorking = '';
            this.getComponentData;
        },
        cancel() {
            this.$emit('showNavigation');
            document.querySelector('#new').style.display = 'none';
            document.querySelector('#display').style.display = 'block';
        },
        edit(id) {
            this.savingMode = 1;
            this.$emit('hideNavigation');
            document.querySelector('#display').style.display = 'none';
            document.querySelector('#new').style.display = 'block';
            let entity = this.experiences[id];
            this.template.companyName = entity.companyName;
            this.template.position = entity.position;
            this.template.begin = entity.begin;
            this.template.end = entity.end;
            this.template.description = entity.description;
            this.template.isWorking = entity.isWorking;
            this.experienceId = id;
        },
        del(id) {
            this.removeComponent5DataById(id);
            window.location.reload();
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
        ...mapGetters(['getComponent5Data']),
        getComponentData() {
            this.experiences = [];
            this.getComponent5Data.forEach(elem => {
                this.experiences.push(elem);
            });
            console.log(this.experiences);
        },
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
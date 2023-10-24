<template>
    <p style="font-size: 30px; font-weight: 700;">Educations</p>
    <div id="display">
        <p style="font-size: 18px; font-weight: 500; color: #808080;">Freelancers who add their experience are twice as likely to win work. But if you’re just starting out, you can still create a great profile. Just head on to the next page.</p>
        <div class="education flex-div" v-for="(item, index) in educations" :key="index" style="border: 1px solid #CDCDCD; border-radius: 10px; padding: 10px; margin: 10px 0;">
            <div>
                <p style="font-size: 20px; font-weight: 600;">{{ item.schoolName }}</p>
                <p style="font-size: 16px; font-weight: 500; color: #808080;">{{ item.degree }}</p>
            </div>
            <div>
                <p style="font-size: 20px; font-weight: 600;">&nbsp;</p>
                <p style="font-size: 16px; font-weight: 500; color: #808080;">{{ item.typeOfStudy }}</p>
            </div>
            <div>
                <button @click="edit(index)" style="padding: 14px 16px; border: 1px solid #1D71B8; border-radius: 6px; margin-right: 5px;"><img src="../../assets/icons/experience_education/Edit.png" alt=""></button>
                <button @click="del(index)" style="padding: 14px 16px; border: 1px solid #1D71B8; border-radius: 6px;"><img src="../../assets/icons/experience_education/Delete.png" alt=""></button>
            </div>
        </div>
        <button @click="createNew()" style="padding: 15px 20px; border: 1px solid #1D71B8; border-radius: 8px; color: #1D71B8; width: 100%; margin: 10px 0; background-color: inherit;">+ Add new</button><br>
    </div>
    <div id="new" style="display: none;">
        <input type="text" v-model="template.schoolName" placeholder="School name" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 90%;"><br>
        <input type="text" v-model="template.degree" placeholder="Degree" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 90%;"><br>
        <input type="text" v-model="template.typeOfStudy" placeholder="Type of study" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 90%;"><br>
        <input type="text" v-model="template.location" placeholder="Location of school" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 90%;"><br>
        <div class="flex-div">
            <div>
                <label for="">Date from</label><br>
                <input type="date" v-model="template.from" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 80%; margin-right: 10px;">
            </div>
            <div>
                <label for="">To</label><br>
                <input type="date" v-model="template.to" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 80%;">
            </div>
        </div>
        <input type="checkbox" v-model="template.currently"> I currently attend here<br>
        <div style="text-align: right;">
            <button @click="cancel()" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer; margin-right: 10px;">Cancel</button>
            <button @click="save(savingMode)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer; margin-right: 10px;">Save</button>
        </div>
    </div>
    
</template>

<script>
import {mapActions, mapGetters} from 'vuex';

export default {
    name: 'Component6',
    components: {},
    data() {
        return {
            educations: [

            ],
            template: {
                schoolName: '',
                degree: '',
                typeOfStudy: '',
                location: '',
                from: '',
                to: '',
                currently: false
            },
            savingMode: 0,
            educationId: 0
        }
    },
    props: {
        saveToStore: Boolean
    },
    methods: {
        ...mapActions(['setComponent6Data', 'editComponent6DataById', 'removeComponent6DataById']),
        createNew() {
            this.savingMode = 0;
            this.$emit('hideNavigation');
            document.querySelector('#display').style.display = 'none';
            document.querySelector('#new').style.display = 'block';
        },
        save(mode) {
            switch(mode) {
                case 0:
                    var obj = {
                        schoolName: this.template.schoolName,
                        degree: this.template.degree,
                        typeOfStudy: this.template.typeOfStudy,
                        location: this.template.location,
                        from: this.template.from,
                        to: this.template.to,
                        currently: this.template.currently
                    }
                    this.setComponent6Data(obj);
                    break;
                case 1:
                    var id = this.educationId;
                    var obj = {
                        schoolName: this.template.schoolName,
                        degree: this.template.degree,
                        typeOfStudy: this.template.typeOfStudy,
                        location: this.template.location,
                        from: this.template.from,
                        to: this.template.to,
                        currently: this.template.currently
                    }
                    this.editComponent6DataById({id: id, obj: obj});
                    break;
            }
            this.$emit('showNavigation');
            document.querySelector('#new').style.display = 'none';
            document.querySelector('#display').style.display = 'block';
            this.template.schoolName = '';
            this.template.degree = '';
            this.template.typeOfStudy = '';
            this.template.location = '';
            this.template.from = '';
            this.template.to = '';
            this.template.currently = '';
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
            var entity = this.educations[id];
            this.template.schoolName = entity.schoolName;
            this.template.degree = entity.degree;
            this.template.typeOfStudy = entity.typeOfStudy;
            this.template.location = entity.location;
            this.template.from = entity.from;
            this.template.to = entity.to;
            this.template.currently = entity.currently;
            this.educationId = id;
        },
        del(id) {
            this.removeComponent6DataById(id);
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
        ...mapGetters(['getComponent6Data']),
        getComponentData() {
            this.educations = [];
            this.getComponent6Data.forEach(elem => {
                this.educations.push(elem);
            });
            console.log(this.educations);
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
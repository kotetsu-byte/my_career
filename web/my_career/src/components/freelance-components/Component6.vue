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
        <div v-if="getIsUpdate === false">
            <input type="text" v-model="template.schoolName" placeholder="School name" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 90%;"><br>
            <input type="text" v-model="template.degree" placeholder="Degree" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 90%;"><br>
            <input type="text" v-model="template.typeOfStudy" placeholder="Type of study" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 90%;"><br>
            <input type="text" v-model="template.location" placeholder="Location of school" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 90%;"><br>
            <div class="flex-div">
                <div>
                    <label for="">Date from</label><br>
                    <input type="date" v-model="template.begin" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 80%; margin-right: 10px;">
                </div>
                <div>
                    <label for="">To</label><br>
                    <input type="date" v-model="template.end" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 80%;">
                </div>
            </div>
            <input type="checkbox" v-model="template.isCurrently"> I currently attend here<br>
        </div>
        <div v-else>
            <input type="text" v-model="updateTemplate.schoolName" placeholder="School name" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 90%;"><br>
            <input type="text" v-model="updateTemplate.degree" placeholder="Degree" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 90%;"><br>
            <input type="text" v-model="updateTemplate.typeOfStudy" placeholder="Type of study" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 90%;"><br>
            <input type="text" v-model="updateTemplate.location" placeholder="Location of school" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 90%;"><br>
            <div class="flex-div">
                <div>
                    <label for="">Date from</label><br>
                    <input type="date" v-model="updateTemplate.begin" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 80%; margin-right: 10px;">
                </div>
                <div>
                    <label for="">To</label><br>
                    <input type="date" v-model="updateTemplate.end" style="padding: 15px 20px; border: 1px solid #CDCDCD; border-radius: 8px; font-size: 20px; font-weight: 500; width: 80%;">
                </div>
            </div>
            <input type="checkbox" v-model="updateTemplate.isCurrently"> I currently attend here<br>
        </div>
        <div style="text-align: right;">
            <button @click="cancel()" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer; margin-right: 10px;">Cancel</button>
            <button @click="save(savingMode)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer; margin-right: 10px;">Save</button>
        </div>
    </div>
</template>

<script>
import {mapActions, mapGetters} from 'vuex';
import API from '../../api';

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
                begin: '',
                end: '',
                isCurrently: false
            },
            updateTemplate: {
                id: 0,
                schoolName: '',
                degree: '',
                typeOfStudy: '',
                location: '',
                begin: '',
                end: '',
                isCurrently: false,
                resumeId: 0
            },
            savingMode: 0,
            educationId: 0,
            updateEducationId: 0
        }
    },
    props: {
        saveToStore: Boolean
    },
    methods: {
        ...mapActions([
            'setComponent6Data', 
            'editComponent6DataById', 
            'removeComponent6DataById',
            'setUpdateEducation',
            'editUpdateEducation',
            'removeUpdateEducationById'
        ]),
        createNew() {
            this.savingMode = 0;
            this.$emit('hideNavigation');
            document.querySelector('#display').style.display = 'none';
            document.querySelector('#new').style.display = 'block';
        },
        save(mode) {
            switch(mode) {
                case 0:
                    if(this.getIsUpdate == false) {
                        let obj = {
                            schoolName: this.template.schoolName,
                            degree: this.template.degree,
                            typeOfStudy: this.template.typeOfStudy,
                            location: this.template.location,
                            beign: this.template.begin,
                            end: this.template.end,
                            isCurrently: this.template.isCurrently
                        }
                        this.setComponent6Data(obj);
                    } else {
                        let obj = {
                            id: this.updateTemplate.id,
                            schoolName: this.updateTemplate.schoolName,
                            degree: this.updateTemplate.degree,
                            typeOfStudy: this.updateTemplate.typeOfStudy,
                            location: this.updateTemplate.location,
                            begin: this.updateTemplate.begin,
                            end: this.updateTemplate.end,
                            isCurrently: this.updateTemplate.isCurrently,
                            resumeId: this.updateTemplate.resumeId
                        }
                        this.setUpdateEducation(obj);
                    }
                    break;
                case 1:
                    if(this.getIsUpdate == false) {
                        let id = this.educationId;
                        let obj = {
                            schoolName: this.template.schoolName,
                            degree: this.template.degree,
                            typeOfStudy: this.template.typeOfStudy,
                            location: this.template.location,
                            beign: this.template.begin,
                            end: this.template.end,
                            isCurrently: this.template.isCurrently
                        }
                        this.editComponent6DataById({id: id, obj: obj});
                    } else {
                        let id = this.updateEducationId;
                        let obj = {
                            id: this.updateTemplate.id,
                            schoolName: this.updateTemplate.schoolName,
                            degree: this.updateTemplate.degree,
                            typeOfStudy: this.updateTemplate.typeOfStudy,
                            location: this.updateTemplate.location,
                            begin: this.updateTemplate.begin,
                            end: this.updateTemplate.end,
                            isCurrently: this.updateTemplate.isCurrently,
                            resumeId: this.updateTemplate.resumeId
                        }
                        this.editUpdateEducation({id: id, obj: obj});
                    }
                    break;
            }
            this.$emit('showNavigation');
            document.querySelector('#new').style.display = 'none';
            document.querySelector('#display').style.display = 'block';
            this.template.schoolName = '';
            this.template.degree = '';
            this.template.typeOfStudy = '';
            this.template.location = '';
            this.template.begin = '';
            this.template.end = '';
            this.template.isCurrently = '';
            this.updateTemplate.id = 0;
            this.updateTemplate.schoolName = '';
            this.updateTemplate.degree = '';
            this.updateTemplate.typeOfStudy = '';
            this.updateTemplate.location = '';
            this.updateTemplate.begin = '';
            this.updateTemplate.end = '';
            this.updateTemplate.isCurrently = '';
            this.updateTemplate.resumeId = '';
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
            if(this.getIsUpdate === false) {
                let entity = this.educations[id];
                this.template.schoolName = entity.schoolName;
                this.template.degree = entity.degree;
                this.template.typeOfStudy = entity.typeOfStudy;
                this.template.location = entity.location;
                this.template.begin = entity.begin;
                this.template.end = entity.end;
                this.template.isCurrently = entity.isCurrently;
                this.educationId = id;
            } else {
                let entity = this.educations[id];
                this.updateTemplate.id = entity.id;
                this.updateTemplate.schoolName = entity.schoolName;
                this.updateTemplate.degree = entity.degree;
                this.updateTemplate.typeOfStudy = entity.typeOfStudy;
                this.updateTemplate.location = entity.location;
                this.updateTemplate.begin = entity.begin;
                this.updateTemplate.end = entity.end;
                this.updateTemplate.isCurrently = entity.isCurrently;
                this.updateTemplate.resumeId = entity.resumeId;
                this.updateEducationId = id;
            }
        },
        del(id) {
            if(this.getIsUpdate === false) {
                this.removeComponent6DataById(id);
            } else {
                let itemId = this.educations[id].id;
                this.removeUpdateEducationById(id);
                API.delete(`/api/Education/${itemId}`)
                    .then(res => {
                        console.log(res.data);
                    }).catch(err => {
                        console.log(err);
                    });
            }
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
        ...mapGetters([
            'getComponent6Data', 
            'getIsUpdate', 
            'getUpdateEducation'
        ]),
        getComponentData() {
            this.educations = [];
            if(this.getIsUpdate == false) {
                this.getComponent6Data.forEach(elem => {
                    this.educations.push(elem);
                });
            } else {
                this.getUpdateEducation.forEach(elem => {
                    this.educations.push(elem);
                });
            }
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
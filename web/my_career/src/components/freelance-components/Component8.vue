<template>
    <p style="font-size: 30px; font-weight: 700; margin: 10px 0;">Select you resume Design</p>
    <p style="font-size: 18px; font-weight: 500; color: #808080; margin: 10px 0;">Your resume is ready! You need to choose one of this templates and all your info will be filled in it already.</p>
    <div class="templates">
        <div class="frame" @click="select(1)" style="padding: 0;">
            <Frame1 />
        </div>
        <div class="frame" @click="select(2)">
            <Frame2 />
        </div>
        <div class="frame" @click="select(3)">
            <Frame3 />
        </div>
        <div class="frame" @click="select(4)">
            <Frame4 />
        </div>
        <div class="frame" @click="select(5)">
            <Frame5 />
        </div>
        <div class="frame" @click="select(6)">
            <Frame6 />
        </div>
    </div>
</template>

<script>
import Frame1 from '../templates/Frame1.vue';
import Frame2 from '../templates/Frame2.vue';
import Frame3 from '../templates/Frame3.vue';
import Frame4 from '../templates/Frame4.vue';
import Frame5 from '../templates/Frame5.vue';
import Frame6 from '../templates/Frame6.vue';
import { mapActions, mapGetters } from 'vuex';

export default {
    name: 'Component8',
    components: {Frame1, Frame2, Frame3, Frame4, Frame5, Frame6},
    data() {
        return {
            selectedTemplate: 0,
            selectedCSS: ''
        }
    },
    props: {
        saveToStore: Boolean
    },
    methods: {
        ...mapActions(['']),
        select(num) {
            this.selectedTemplate = num;
            document.querySelectorAll('.frame').forEach(elem => {
                elem.classList.remove('selected');
            })
            document.querySelectorAll('.frame')[num - 1].classList.add('selected');
        },
        sendComponentDataToStore() {
            var obj = {
                selectedTemplate: this.selectedTemplate
            };
            this.setComponent1Data(obj);
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
        ...mapGetters(['']),

    },
    mounted() {

    }
}
</script>

<style scoped>
.container {
    margin: 100px auto 0 auto;
    min-width: 400px;
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

.template {
    display: block;
}

.selected {
    border: 3px solid blue;
}
</style>
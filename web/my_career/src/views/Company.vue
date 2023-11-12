<template>
    <div id="cont">
        <button onclick="location.href = '/home'">Back to log in</button>
        <div class="container">
            <component :is="componentName" :saveToStore="savingComponentsData" @nextPrevPage="nextOrPrev" @hideNavigation="hideNav" @showNavigation="showNav"></component>
            <div style="text-align: right;">
                <div id="navigation" v-if="isNavShown">
                    <button v-if="!(sectionNo == 1)" @click="save('prev')" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer; margin-right: 10px;">Prev</button>
                    <button @click="save('next')" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Next</button>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
import Component1 from '../components/company-components/Component1.vue';
import Component2 from '../components/company-components/Component2.vue';
import Component3 from '../components/company-components/Component3.vue';
import Component4 from '../components/company-components/Component4.vue';
import Component5 from '../components/company-components/Component5.vue';
import { mapGetters, mapActions } from 'vuex';

export default {
    name: 'Company',
    components: {Component1, Component2, Component3, Component4, Component5},
    data() {
        return {
            sectionNo: 0,
            componentName: null,
            savingComponentsData: false,
            isNext: null,
            isNavShown: true
        }
    },
    methods: {
        ...mapActions(['setCompanySectionNo']),
        save(where) {
            if(where == 'prev') {
                this.isNext = false;
            }
            if(where == 'next') {
                this.isNext = true;
            }
            this.savingComponentsData = true;
        },
        next() {
            if(this.sectionNo >= 5) {
                this.$router.push('/company-ready');
            }
            if(this.sectionNo < 5) {
                this.sectionNo++;
            }
            this.setCompanySectionNo(this.sectionNo);
            this.showComponenet();
            this.savingComponentsData = false;
        },
        prev() {
            if(this.sectionNo > 1) {
                this.sectionNo--;
            }
            this.setCompanySectionNo(this.sectionNo);
            this.showComponenet();
            this.savingComponentsData = false;
        },
        nextOrPrev() {
            if(this.isNext === true) {
                this.next();
            }
            if(this.isNext === false) {
                this.prev();
            }
        },
        showComponenet() {
            switch(this.sectionNo) {
                case 1:
                    this.componentName = 'Component1';
                    break;
                case 2:
                    this.componentName = 'Component2';
                    break;
                case 3:
                    this.componentName = 'Component3';
                    break;
                case 4:
                    this.componentName = 'Component4';
                    break;
                case 5:
                    this.componentName = 'Component5';
                    break;
            }
        },
        hideNav() {
            this.isNavShown = false;
        },
        showNav() {
            this.isNavShown = true;
        },
    },
    computed: {
        ...mapGetters(['getCompanySectionNo']),
        getNoSection() {
            this.sectionNo = this.getCompanySectionNo;
            this.showComponenet();
        }
    },
    mounted() {
        this.getNoSection;
    }
}
</script>

<style scoped>
#cont {
    background-color: #F4F8FB;
    height: 100vh;
}
.container {
    margin: 100px auto 0 auto;
    max-width: 600px;
    width: max-content;
    background-color: white;
    border-radius: 12px;
    padding: 20px;
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
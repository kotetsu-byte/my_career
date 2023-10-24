<template> 
    <div id="cont">
        <button onclick="location.href = '/login'">Back to log in</button>
        <div class="container">
            <component :is="componentName" :saveToStore="savingCompnentsData" @nextPage="next" @hideNavigation="hideNav" @showNavigation="showNav"></component>
            <div style="text-align: right;">
                <div id="navigation">
                    <button v-if="!(sectionNo == 1)" @click="prev()" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer; margin-right: 10px;">Prev</button>
                    <button v-if="!(sectionNo == 8)" @click="save()" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Next</button>
                </div>
            </div>
        </div>
    </div>
</template>

<script lang="jsx">
import Component1 from '../components/freelance-components/Component1.vue';
import Component2 from '../components/freelance-components/Component2.vue';
import Component3 from '../components/freelance-components/Component3.vue';
import Component4 from '../components/freelance-components/Component4.vue';
import Component5 from '../components/freelance-components/Component5.vue';
import Component6 from '../components/freelance-components/Component6.vue';
import Component7 from '../components/freelance-components/Component7.vue';
import Component8 from '../components/freelance-components/Component8.vue';

import { mapGetters, mapActions } from 'vuex';

export default {
    name: 'Freelance',
    components: {Component1, Component2, Component3, Component4, Component5, Component6, Component7, Component8},
    data() {
        return {
            sectionNo: 0,
            compo: null,
            savingCompnentsData: false
        }
    },
    methods: {
        ...mapActions(['setSectionNo']),
        save() {
            if((this.sectionNo > 4) && (this.sectionNo < 8))
            {
                this.next();
            } else {
                this.savingCompnentsData = true;
            }
        },
        next() {
            if(this.sectionNo < 8) {
                this.sectionNo++;
            }
            this.setSectionNo(this.sectionNo);
            this.showComponenet();
            this.savingCompnentsData = false;
        },
        prev() {
            if(this.sectionNo > 1) {
                this.sectionNo--;
            }
            this.setSectionNo(this.sectionNo);
            this.showComponenet();
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
                case 6:
                    this.componentName = 'Component6';
                    break;
                case 7:
                    this.componentName = 'Component7';
                    break;
                case 8:
                    this.componentName = 'Component8';
                    break;
            }
        },
        hideNav() {
            document.querySelector('#navigation').style.display = 'none';
        },
        showNav() {
            document.querySelector('#navigation').style.display = 'block';
        },
    },
    computed: {
        ...mapGetters(['getSectionNo']),
        getNoSection() {
            this.sectionNo = this.getSectionNo;
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

#section-2, #section-3, #section-4, #section-5, #section-6, #section-7, #section-8 {
    display: none;
} 
</style>